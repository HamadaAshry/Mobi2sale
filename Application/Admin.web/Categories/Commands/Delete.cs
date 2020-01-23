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

namespace Application.Admin.web.Categories.Commands {
    public class Delete {
        public class Command : IRequest {
            //Add Dto properties here
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
                //Add handler Logic.
                var DbCategory = (await _uow.CatRepo.FindAsync(c => c.IsDeleted && c.Id == command.Id)).FirstOrDefault();
                if (DbCategory == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"Category of Id ={command.Id} not found " });
                DbCategory.IsDeleted = true;
                var succeded = await _uow.SaveAsync () > 0;
                if (succeded) {
                    var deleted = _fHandler.DeleteFile (DbCategory.ImageUrl,"category");                    
                    if(!deleted) throw new Exception ("Error Deleting the old image!");
                    return Unit.Value;
                }
                throw new Exception ("Error saving The data!");
            }
        }
    }
}