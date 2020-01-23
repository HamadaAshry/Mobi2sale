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
using MediatR;

namespace Application.Admin.web.Items.Quries {
    public class ItemDetails {
        public class Query : IRequest<ItemResponseDto> {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, ItemResponseDto> {
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public Handler (IUnitOfWork uow, IMapper mapper) {
                _mapper = mapper;
                _uow = uow;
            }

            public async Task<ItemResponseDto> Handle (Query request, CancellationToken cancellationToken) {
                //Add handler logic here.

                var item = (await _uow.ItemRepo.FindAsync(i=>!i.IsDeleted&&i.Id==request.Id)).FirstOrDefault();
                if (item == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"Item of Id ={request.Id} not found " });
                return _mapper.Map<Item, ItemResponseDto> (item);
            }

        }
    }
}