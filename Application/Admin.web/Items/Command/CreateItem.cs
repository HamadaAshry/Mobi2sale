using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.Items.Dtos;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Items;
using FluentValidation;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Admin.web.Items.Command {
    public class CreateItem {
        public class Command : IRequest<ItemResponseDto> {
            //Add Request object properties
            public string Name { get; set; }

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
                RuleFor (p => p.CoverImage).NotEmpty ();
                RuleFor (p => p.MainImage).NotEmpty ();
                RuleFor (p => p.Name).NotEmpty ();
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
                { //Add your logic Here

                    var newItem = _mapper.Map<Command, Item> (command);
                    await SaveitemImages (command, newItem);

                    await _uow.ItemRepo.AddAsync (newItem);
                    return await _uow.SaveAsync () > 0 ? _mapper.Map<Item, ItemResponseDto> (newItem) :
                        throw new Exception ("Error saving The data!");

                }

            }

            private async Task<Item> SaveitemImages (Command command, Item newItem) {
                var mainImageUrl = await SaveFile (command.MainImage,ismainImage: true);
                var coverImageUrl = await SaveFile (command.CoverImage,ismainImage: false);

                if (string.IsNullOrEmpty (mainImageUrl)) throw new Exception ("Error saving The Main Image!");
                if (string.IsNullOrEmpty (coverImageUrl)) throw new Exception ("Error saving The Cover Image!");

                newItem.MainImageUrl = mainImageUrl;
                newItem.CoverImageUrl = coverImageUrl;

                return newItem;
            }

            private async Task<string> SaveFile (IFormFile file, bool ismainImage) {

                if (ismainImage) _fhandler.ValiadteMainFile (file);

                if (!ismainImage) _fhandler.ValiadteFile (file);

                if (file.Length == 0) return null;

                return await _fhandler.SaveFile (file, "item");

            }
        }
    }
}