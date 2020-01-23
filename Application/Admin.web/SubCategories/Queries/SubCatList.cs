using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Admin.web.SubCategories.Dtos;
using Application.Interfaces;
using Application.Interfaces.Persistence;
using AutoMapper;
using MediatR;
using Domain.AdminPanel.Web.Subcategories;
using System;
using FluentValidation;

namespace Application.Admin.web.SubCategories.Queries
{
    public class SubCatList
    {
        
        public class Query : IRequest<IEnvelopes<ListSubcategoryResponseDto>>
        {
            public Query(IPaginationAndFilterProps pageProps, System.Guid catId,IEnvelopes<ListSubcategoryResponseDto> envelope )
            {
                PageProps = pageProps;
                CatId = catId;
                Envelope = envelope;
            }
            

            public IPaginationAndFilterProps PageProps { get; }
            public Guid CatId { get; }
            public IEnvelopes<ListSubcategoryResponseDto> Envelope { get; }
        }

          public class ItemsValidator : AbstractValidator<Query>
        {
            public ItemsValidator()
            {
                RuleFor(p=>p.CatId).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Query, IEnvelopes<ListSubcategoryResponseDto>>
        {
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public Handler(IUnitOfWork uow, IMapper mapper)
            {
                _mapper = mapper;
                _uow = uow;
            }

            public async Task<IEnvelopes<ListSubcategoryResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var subcategories =await  _uow.SupCatRepo.FindSubCategoriesBycategoryId(request.PageProps, request.CatId);
                 request.Envelope.Data=_mapper.Map<List<SubCategory>,List<ListSubcategoryResponseDto>>(subcategories.Data.ToList());
                 request.Envelope.RecordsCount=subcategories.RecordsCount;
                
                return request.Envelope   ;
            }
        }
    }
}