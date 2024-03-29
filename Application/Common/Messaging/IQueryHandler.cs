﻿
using Application.FinancialYears.Queries;
using Domain.Shared;
using MediatR;

namespace Application.Common.Messaging
{
    public interface IQueryHandler<TQuery, TResponse>
        : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
       // Task<Result<FinancialYearDto>> Handle(GetLastFinancialYearQuery request, CancellationToken cancellationToken);
    }


}
