using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.Items.Dtos;
using Application.Interfaces;
using Application.Interfaces.Persistence;
using AutoMapper;
using Domain.AdminPanel.Web.Items;
using FluentValidation;
using MediatR;

namespace Application.Admin.web.Items.Quries {
    public class ItemList {
        public class Query : IRequest<IEnvelopes<ItemsResponseDto>> {
            public Query (Guid subcategoryId, IPaginationAndFilterProps pageProps, IEnvelopes<ItemsResponseDto> env) {
                this.Env = env;
                SubcategoryId = subcategoryId;
                PageProps = pageProps;
            }

            public Guid SubcategoryId { get; set; }

            public IPaginationAndFilterProps PageProps { get; }

            public IEnvelopes<ItemsResponseDto> Env { get; set; }

        }

        public class ItemsValidator : AbstractValidator<Query>
        {
            public ItemsValidator()
            {
                RuleFor(p=>p.SubcategoryId).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Query, IEnvelopes<ItemsResponseDto>> {
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;

            public Handler (IMapper mapper, IUnitOfWork uow) {
                this._uow = uow;
                _mapper = mapper;
            }
            public async Task<IEnvelopes<ItemsResponseDto>> Handle (Query query, CancellationToken cancellationToken) {
                //Add your logic Here
                var itemsEnv = await _uow.ItemRepo.FindItemsBySubcategoryId (query.PageProps, query.SubcategoryId);
                query.Env.Data= _mapper.Map<List<Item>,List<ItemsResponseDto>>(itemsEnv.Data);
                query.Env.RecordsCount=itemsEnv.RecordsCount;
                return query.Env;
                 

            }

        }
    }
}