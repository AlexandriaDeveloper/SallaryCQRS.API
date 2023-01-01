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
    public record GetEmployeesListQuery(GetEmployeeListQueryParam param) : IQuery<PagedList<EmployeeDto>>;
    public class GetEmployeesListQueryHandler : IQueryHandler<GetEmployeesListQuery, PagedList<EmployeeDto>>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesListQueryHandler(IUOW uow,IMapper mapper) 
        {
            _uow = uow;
            _mapper = mapper;
        }
   

       async Task<Result<PagedList<EmployeeDto>>> IRequestHandler<GetEmployeesListQuery, Result <PagedList<EmployeeDto>>>.Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetEmployeeListQuerySpecification(request.param);
           
            var data = await _uow.EmployeeRepository.GetAllAsync(spec, false);
            var EmployeeToReturn = _mapper.Map<List<EmployeeDto>>(data.Data);
 

            return Result<EmployeeDto>.Success(new PagedList<EmployeeDto>(EmployeeToReturn, data.Pagination));
        }
    }



    }
