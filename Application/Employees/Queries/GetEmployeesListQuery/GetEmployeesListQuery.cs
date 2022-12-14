using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;
using Application.Common;
using Domain.Primitives;
using AutoMapper;

namespace Application.Employees.Queries.GetEmployeesListQuery
{
    public record GetEmployeesListQuery(GetEmployeeListQueryParam param) : IRequest<Result<IReadOnlyList<EmployeeDto>>>;
    public class GetEmployeesListQueryHandler : Handler<GetEmployeesListQuery, Result<IReadOnlyList<EmployeeDto>>>
    {
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IUOW uow,IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public override async Task<Result<IReadOnlyList<EmployeeDto>>> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {


            var spec = new GetEmployeeListQuerySpecification(request.param);


            var EmployeeToReturn = _mapper.Map<List< EmployeeDto>>(await _uow.EmployeeRepository.GetAllAsync(spec));
            return Result<IReadOnlyList<EmployeeDto>>.Success(EmployeeToReturn);
        }

    }



    }
