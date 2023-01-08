using Application.Common.Messaging;
using Application.FinancialYears;
using AutoMapper;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.FinancialYears.Queries
{
    public record GetLastFinancialYearQuery : IQuery<FinancialYearDto>;
    public class GetLastFinancialYearQueryHandler : IQueryHandler<GetLastFinancialYearQuery, FinancialYearDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetLastFinancialYearQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<Result<FinancialYearDto>> Handle(GetLastFinancialYearQuery request, CancellationToken cancellationToken)
        {
            var specs = new GetFinancialYearDescQuerySpecification();
            var lastYear = await _uow.FinancialYearRepository
                 .GetBySingleOrDefaultAsync(specs, false); 

            if(lastYear.Data.FirstOrDefault() == null) {
                return Result.Failure< FinancialYearDto>(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var resultToReturn = _mapper.Map<FinancialYearDto>(lastYear.Data.FirstOrDefault());
            return Result< FinancialYearDto>.Success(resultToReturn);
        }
    }
}
