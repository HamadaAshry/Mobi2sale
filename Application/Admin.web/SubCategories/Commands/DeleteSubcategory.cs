using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces.Persistence;
using AutoMapper;
using Infrastructure;
using MediatR;

namespace Application.Admin.web.SubCategories.Commands {
    public class DeleteSubcategory {
        public class Command : IRequest {
            //Add Post Dto Props
            public Guid Id { get; set; }

        }

        public class Handler : IRequestHandler<Command> {
          private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;
            private readonly IFileHandler _fHandler;
            public Handler (IMapper mapper, IUnitOfWork uow, IFileHandler fHandler) {
                this._fHandler = fHandler;
                this._uow = uow;
                _mapper = mapper;

            }
            public async Task<Unit> Handle (Command command, CancellationToken cancellationToken) {
                var DbSubcategory = (await _uow.SupCatRepo.FindAsync(sc => sc.Id == command.Id && !sc.IsDeleted)).FirstOrDefault();
                if (DbSubcategory == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"subcategory of Id ={command.Id} not found " });
                DbSubcategory.IsDeleted = true;
                var succeded = await _uow.SaveAsync () > 0;
                if (succeded) {
                    var deleted = _fHandler.DeleteFile (DbSubcategory.ImageUrl,"subcategory");                    
                    if(!deleted) throw new Exception ("Error Deleting the old image!");
                    return Unit.Value;
                }
                throw new Exception ("Error saving The data!");
            }
        }
    }
}