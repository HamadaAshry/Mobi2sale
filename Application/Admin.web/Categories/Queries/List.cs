using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Persistence;
using Domain.AdminPanel.Web.Categories;
using MediatR;
using System.Linq;
using AutoMapper;
using Application.Admin.web.Categories.Dtos;

namespace Application.Admin.web.Categories
{
    public class List
    {
        public class Query : IRequest<List<ListResponseDto>>
        {
          
        }

        public class Handler : IRequestHandler<Query, List<ListResponseDto>>
        {
            private readonly IUnitOfWork _uow;
            private readonly IMapper _mapper;
            public Handler(IUnitOfWork uow, IMapper mapper)
            {
                _mapper = mapper;
                _uow = uow;
            }

            public async Task<List<ListResponseDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var categories=await _uow.CatRepo.FindAsync(c=>!c.IsDeleted); 
                return _mapper.Map<List<Category>,List<ListResponseDto>>(categories.ToList());   ;
            }
        }
    }
}