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

namespace Application.Admin.web.Items.Command
{
    public class DeleteItem
    {
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
                var Dbitem = (await _uow.ItemRepo.FindAsync(i => !i.IsDeleted && i.Id == command.Id)).FirstOrDefault(); ;
                if (Dbitem == null) throw new RestException (HttpStatusCode.NotFound, new { message = $"item of Id ={command.Id} not found " });
                Dbitem.IsDeleted = true;
                var succeded = await _uow.SaveAsync () > 0;
                if (succeded) {
                    var deleted = _fHandler.DeleteFile (Dbitem.CoverImageUrl,"item");                    
                    if(!deleted) throw new Exception ("Error Deleting the old cover image!");
                        deleted = _fHandler.DeleteFile (Dbitem.MainImageUrl,"item");                    
                    if(!deleted) throw new Exception ("Error Deleting the old main image!");
                    return Unit.Value;
                }
              
                throw new Exception ("Error saving The data!");
            }
        }
    }
}