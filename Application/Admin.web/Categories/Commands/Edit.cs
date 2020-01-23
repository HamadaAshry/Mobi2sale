using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.Categories.Dtos;
using Application.Errors;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Categories;
using FluentValidation;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Admin.web.Categories.Commands {
    public class Edit {
        public class Command : IRequest<EditCategoryResponseDto> {
            //Add Dto properties here
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public IFormFile Image { get; set; }

        }
        public class CommandValidator : AbstractValidator<Command> {
            public CommandValidator () {
                RuleFor (p => p.Id).NotEmpty ();
                RuleFor (p => p.Name).NotEmpty ();
            }
        }
        public class Handler : IRequestHandler<Command, EditCategoryResponseDto> {
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;
            public IFileHandler _fHandler { get; set; }
            public Handler (IMapper mapper, IUnitOfWork uow, IFileHandler fHandler) {
                _fHandler = fHandler;
                this._uow = uow;
                _mapper = mapper;

            }
            public async Task<EditCategoryResponseDto> Handle (Command command, CancellationToken cancellationToken)
            {
                var DbCategory = (await _uow.CatRepo.FindAsync(c => c.IsDeleted && c.Id == command.Id)).FirstOrDefault();
                if (DbCategory == null) throw new RestException(HttpStatusCode.NotFound, new { message = $"Category of Id ={command.Id} not found " });
                if (command.Image?.Length>0)
                {
                 var newUrl=await HandleNewImage(command, DbCategory);
                 DbCategory.ImageUrl=newUrl;
                }
                DbCategory = _mapper.Map<Command, Category>(command, DbCategory);
                return await _uow.SaveAsync() > 0 ? _mapper.Map<Category, EditCategoryResponseDto>(DbCategory) :
                    throw new Exception("Error saving The data!");
            }

            private async Task<string> HandleNewImage(Command command, Category DbCategory)
            {
                    _fHandler.ValiadteFile(command.Image);
                    var newUrl = await _fHandler.SaveFile(command.Image, "category");
                    if (!string.IsNullOrEmpty(newUrl))
                    {
                        var deleted=_fHandler.DeleteFile(DbCategory.ImageUrl, "category");   
                        if(!deleted)  throw new Exception("Error deleting The old image!");
                        return  newUrl;                   
                    }
                    throw new Exception("Error saving The image!");
                
            }
        }
    }
}