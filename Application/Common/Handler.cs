using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public abstract class Handler<TIn,TOut>  :IRequestHandler<TIn ,TOut> where TIn :IRequest<TOut>
    {
        protected readonly IUOW _uow;

 

        public Handler(IUOW uow)
        {
            this._uow = uow;
        }

        public abstract Task<TOut> Handle(TIn request, CancellationToken cancellationToken);
       
    }
}
