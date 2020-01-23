using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.SubCategories.Dtos;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Subcategories;
using FluentValidation;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Admin.web.SubCategories.Commands {
        public class CreateSubcategory {
            public class Command : IRequest<CreateSubCategoryReponseDto> {
                //Add Request object properties
                public string Name { get; set; }
                public string Description { get; set; }
                public Guid CategoryId { get; set; }
                public IFormFile File { get; set; }

            }
            public class CommandValidator : AbstractValidator<Command> {
                public CommandValidator () {
                    RuleFor (p => p.Name).NotEmpty ();
                    RuleFor (p => p.File).NotEmpty ();
                    RuleFor (p => p.CategoryId).NotEmpty ();
                }
            }

            public class Handler : IRequestHandler<Command, CreateSubCategoryReponseDto> {
                private readonly IMapper _mapper;
                private readonly IUnitOfWork _uow;
                private readonly IFileHandler _fhandler;

                public Handler (IMapper mapper, IUnitOfWork uow, IFileHandler fhandler) {
                    this._fhandler = fhandler;
                    this._uow = uow;
                    _mapper = mapper;
                }
                public async Task<CreateSubCategoryReponseDto> Handle (Command command, CancellationToken cancellationToken)
            {
                //Add your logic Here
                _fhandler.ValiadteFile(command.File);

                var newSubcategory = _mapper.Map<Command, SubCategory>(command);
                var url = await SaveFile(command.File);
                if (string.IsNullOrEmpty(url)) throw new Exception("Error saving The Image!");
                newSubcategory.ImageUrl = url;

                await _uow.SupCatRepo.AddAsync(newSubcategory);
                return await _uow.SaveAsync() > 0 ? _mapper.Map<SubCategory, CreateSubCategoryReponseDto>(newSubcategory) :
                    throw new Exception("Error saving The data!");

            }         

            private async Task<string> SaveFile(IFormFile file)
            {
                if (file.Length == 0) return null;
                 
                return await _fhandler.SaveFile(file,"subcategory"); 

            }
            }
        }
}