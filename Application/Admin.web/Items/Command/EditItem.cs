using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.Items.Dtos;
using Application.Errors;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Items;
using FluentValidation;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Admin.web.Items.Command {
    public class EditItem {
        public class Command : IRequest<ItemResponseDto> {
            //Add Request object properties
            public string Name { get; set; }
            public Guid Id { get; set; }

            public string Description { get; set; }

            public Decimal SupplyPrice { get; set; }

            public Decimal RetailPrice { get; set; }

            public Decimal WholesalePrice { get; set; }

            public string Color { get; set; }

            public string Code { get; set; }

            public int Quantity { get; set; }

            public int SafeLimit { get; set; }

            public IFormFile MainImage { get; set; }

            public IFormFile CoverImage { get; set; }

            public Guid SubcategoryId { get; set; }

        }
        public class CommandValidator : AbstractValidator<Command> {
            public CommandValidator () {
                //Add validation rules
                RuleFor (p => p.Name).NotEmpty ();
                RuleFor (p => p.Id).NotEmpty ();
                RuleFor (p => p.SupplyPrice).NotEmpty ();
                RuleFor (p => p.WholesalePrice).NotEmpty ();
                RuleFor (p => p.RetailPrice).NotEmpty ();
                RuleFor (p => p.SafeLimit).NotEmpty ();
                RuleFor (p => p.Quantity).NotEmpty ();
                RuleFor (p => p.SubcategoryId).NotEmpty ();
                RuleFor (p => p.Color).NotEmpty ();
                RuleFor (p => p.Code).NotEmpty ();
                RuleFor (p => p.Quantity).GreaterThan (p => p.SafeLimit);
                RuleFor (p => p.RetailPrice).GreaterThan (p => p.WholesalePrice);
                RuleFor (p => p.SupplyPrice).LessThanOrEqualTo (p => p.WholesalePrice);
                RuleFor (p => p.SupplyPrice).LessThanOrEqualTo (p => p.RetailPrice);
            }
        }

        public class Handler : IRequestHandler<Command, ItemResponseDto> {
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;
            private readonly IFileHandler _fhandler;

            public Handler (IMapper mapper, IUnitOfWork uow, IFileHandler fhandler) {
                this._fhandler = fhandler;
                this._uow = uow;
                _mapper = mapper;
            }
            public async Task<ItemResponseDto> Handle (Command command, CancellationToken cancellationToken) {
                //Add your logic Here
                var Dbitem = (await _uow.ItemRepo.FindAsync(i => !i.IsDeleted && i.Id == command.Id)).FirstOrDefault();
                if (Dbitem == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"Item of Id ={command.Id} not found " });
                if (command.CoverImage?.Length > 0) {
                    Dbitem = await HandleCoverImage (command, Dbitem);                   
                }
                if (command.MainImage?.Length > 0) {
                    Dbitem = await HandleMainImage (command, Dbitem);                    
                }
                Dbitem = _mapper.Map<Command, Item> (command, Dbitem);
                return await _uow.SaveAsync () > 0 ? _mapper.Map<Item, ItemResponseDto> (Dbitem) :
                    throw new Exception ("Error saving The data!");

            }
            private async Task<Item> HandleCoverImage (Command command, Item item) {
               _fhandler.ValiadteFile (command.CoverImage);            
             
               var coverImageUrl = await _fhandler.SaveFile (command.CoverImage, "item");

                 if (!string.IsNullOrEmpty (coverImageUrl)) {
                    var deleted = _fhandler.DeleteFile (item.CoverImageUrl, "item");
                    if (!deleted) throw new Exception ("Error deleting The old cover image!");
                    item.CoverImageUrl=coverImageUrl;
                    return item;
                }
                throw new Exception ("Error saving The cover image!");

            }
              private async Task<Item> HandleMainImage (Command command, Item item) {
              _fhandler.ValiadteMainFile (command.MainImage);
               var mainImageUrl = await _fhandler.SaveFile (command.MainImage, "item");
                if (!string.IsNullOrEmpty (mainImageUrl)) {
                    var deleted = _fhandler.DeleteFile (item.MainImageUrl, "item");
                    if (!deleted) throw new Exception ("Error deleting The old main image!");
                     item.MainImageUrl=mainImageUrl;
                     return item;
                }                 
                throw new Exception ("Error saving The main image!");

            }

        }
    }
}