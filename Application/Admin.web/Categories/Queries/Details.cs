using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces.Persistence;
using AutoMapper;
using CommonHelpers;
using Domain.AdminPanel.Web.Categories;
using MediatR;

namespace Application.Admin.web.Categories.Queries {
    public class Details {
        public class Query : IRequest<Details.Query> {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }

        }

        public class Handler : IRequestHandler<Query, Details.Query> {
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            private readonly IResponseHandler _response;

            public Handler (IUnitOfWork uow, IMapper mapper,IResponseHandler response) {
                this._mapper = mapper;
                this._response = response;
                _uow = uow;

            }
            public async Task<Details.Query> Handle (Query request, CancellationToken cancellationToken) {
                var category = (await _uow.CatRepo.FindAsync (c=>c.IsDeleted&&c.Id==request.Id)).FirstOrDefault();
                if (category==null) throw new RestException(HttpStatusCode.NotFound,new{message=$"Category of Id ={request.Id} not found "});                
                return _mapper.Map<Category, Details.Query> (category);
            }
        }
    }
}