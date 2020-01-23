using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.SubCategories.Dtos;
using Application.Errors;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Subcategories;
using FluentValidation;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Admin.web.SubCategories.Commands {
    public class EditSubCategory {
        public class Command : IRequest<EditSubcatResponseDto> {
            //Add Request object properties
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Guid CategoryId { get; set; }
            public IFormFile File { get; set; }

        }
        public class CommandValidator : AbstractValidator<Command> {
            public CommandValidator () {
                //Add validation rules
                RuleFor (p => p.Name).NotEmpty ();
                RuleFor (p => p.CategoryId).NotEmpty ();
            }
        }

        public class Handler : IRequestHandler<Command, EditSubcatResponseDto> {
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;
            private readonly IFileHandler _fhandler;

            public Handler (IMapper mapper, IUnitOfWork uow, IFileHandler fhandler) {
                this._fhandler = fhandler;
                this._uow = uow;
                _mapper = mapper;
            }
            public async Task<EditSubcatResponseDto> Handle (Command command, CancellationToken cancellationToken) {
                //Add your logic Here
                var Dbsubcategory = (await _uow.SupCatRepo.FindAsync(sc => sc.Id == command.Id && !sc.IsDeleted)).FirstOrDefault();
                if (Dbsubcategory == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"Subcategory of Id ={command.Id} not found " });
                if (command.File?.Length > 0) {
                    var newUrl = await HandleNewImage (command, Dbsubcategory);
                    Dbsubcategory.ImageUrl = newUrl;
                }
                Dbsubcategory = _mapper.Map<Command, SubCategory> (command, Dbsubcategory);
                return await _uow.SaveAsync () > 0 ? _mapper.Map<SubCategory, EditSubcatResponseDto> (Dbsubcategory) :
                    throw new Exception ("Error saving The data!");

            }
            private async Task<string> HandleNewImage (Command command, SubCategory DbSubcategory) {
                _fhandler.ValiadteFile (command.File);
                var newUrl = await _fhandler.SaveFile (command.File, "subcategory");
                if (!string.IsNullOrEmpty (newUrl)) {
                    var deleted = _fhandler.DeleteFile (DbSubcategory.ImageUrl, "subcategory");
                    if (!deleted) throw new Exception ("Error deleting The old image!");
                    return newUrl;
                }
                throw new Exception ("Error saving The image!");

            }

        }
    }
}