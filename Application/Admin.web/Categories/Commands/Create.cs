using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.Categories.Dtos;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Categories;
using FluentValidation;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Admin.web.Categories.Commands
{
    public class Create
    {
        public class Command : IRequest<CreateReponseDto>
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public IFormFile File { get; set; }

        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(p => p.Name).NotEmpty();
                RuleFor(p => p.File).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, CreateReponseDto>
        {
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;
            private readonly IFileHandler _fHandler;
            public Handler(IMapper mapper, IUnitOfWork uow, IFileHandler fHandler)
            {
                this._fHandler = fHandler;
                this._uow = uow;
                _mapper = mapper;
            }
            public async Task<CreateReponseDto> Handle(Command command, CancellationToken cancellationToken)
            {
               _fHandler.ValiadteFile(command.File);

                var newCategory = _mapper.Map<Create.Command, Category>(command);
                var url=await SaveFile(command.File);
                if(string.IsNullOrEmpty(url))throw new Exception("Error saving The Image!");
                newCategory.ImageUrl=url;

                await _uow.CatRepo.AddAsync(newCategory);
                return await _uow.SaveAsync() > 0 ? _mapper.Map<Category, CreateReponseDto>(newCategory) :
                    throw new Exception("Error saving The data!");

            }

            private async Task<string> SaveFile(IFormFile file)
            {
                if (file.Length == 0) return null;
                 
                return await _fHandler.SaveFile(file,"category"); 

            }

        }
    }
}