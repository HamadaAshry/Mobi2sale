using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces.Persistence;
using AutoMapper;
using CommonHelpers;
using Domain.AdminPanel.Web.Subcategories;
using MediatR;

namespace Application.Admin.web.SubCategories.Queries {
    public class SubCatDetails {
        public class Query : IRequest<SubCatDetails.Query> {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public Guid CategoryId { get; set; }

        }

        public class Handler : IRequestHandler<Query, SubCatDetails.Query> {
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;

            public Handler (IUnitOfWork uow, IMapper mapper) {
                this._mapper = mapper;
                _uow = uow;

            }
            public async Task<SubCatDetails.Query> Handle (Query request, CancellationToken cancellationToken) {
                var subcategory = (await _uow.SupCatRepo.FindAsync(sc=>sc.Id==request.Id&&!sc.IsDeleted)).FirstOrDefault();
                if (subcategory == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"subcategory of Id ={request.Id} not found " });
                return _mapper.Map<SubCategory, SubCatDetails.Query> (subcategory);
            }
        }
    }
}