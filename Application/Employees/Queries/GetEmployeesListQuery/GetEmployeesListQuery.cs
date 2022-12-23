using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Interfaces;
using Domain.Shared;
using Domain.Primitives;
using AutoMapper;
using System.Collections.ObjectModel;
using Application.Common.Messaging;

namespace Domain.Employees.Queries.GetEmployeesListQuery
{
    public record GetEmployeesListQuery(GetEmployeeListQueryParam param) : IQuery<IReadOnlyList<EmployeeDto>>;
    public class GetEmployeesListQueryHandler : IQueryHandler<GetEmployeesListQuery, IReadOnlyList<EmployeeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IUOW uow,IMapper mapper) 
        {
            _uow = uow;
            _mapper = mapper;
        }
   

       async Task<Result<IReadOnlyList<EmployeeDto>>> IRequestHandler<GetEmployeesListQuery, Result<IReadOnlyList<EmployeeDto>>>.Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeListQuerySpecification(request.param);


            var EmployeeToReturn = _mapper.Map<IReadOnlyList<EmployeeDto>>(await _uow.EmployeeRepository.GetAllAsync(spec, false));

            return Result<IReadOnlyList<EmployeeDto>>.Success(EmployeeToReturn);
        }
    }



    }
