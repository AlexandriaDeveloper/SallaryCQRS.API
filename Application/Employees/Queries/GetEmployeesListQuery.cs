using MediatR;
using Domain.Models;
using Application.Interfaces;
using Application.Common;

namespace Application.Employees.Queries
{

    //public class GetEmployeeListQueryParam : Param {
    //    public string? Name { get; set; }
    //    public string? TabCode { get; set; }
    //    public string? TegaraCode { get; set; }

    //    public string? NationalId { get; set; }
    //};
    //public class GetEmployeeListQuerySpecification :Specification<Employee>
    //{
    //    public GetEmployeeListQuerySpecification(GetEmployeeListQueryParam param):base()
    //    {
    //        if (!string.IsNullOrEmpty(param.Name)) { 
    //            AddCriteries(x => x.Name.Contains(param.Name));
    //        }
    //        if (!string.IsNullOrEmpty(param.TabCode))
    //        {
    //            AddCriteries(x => x.TabCode.Equals(param.TabCode));
    //        }
    //        if (!string.IsNullOrEmpty(param.TegaraCode))
    //        {
    //            AddCriteries(x => x.TegaraCode.Equals(param.TegaraCode));
    //        }
    //        if (!string.IsNullOrEmpty(param.NationalId))
    //        {
    //            AddCriteries(x => x.NationalId.Equals(param.NationalId));
    //        }

    //    }
    //}
  //  public record GetEmployeesListQuery (GetEmployeeListQueryParam param) : IRequest<Result<IReadOnlyList<Employee> >>;
    //public class GetEmployeesListQueryHandler : Handler<GetEmployeesListQuery, Result<IReadOnlyList<Employee>>>
    //{
    //    public GetEmployeesListQueryHandler(IUOW uow) : base(uow)
    //    {
    //    }

    //    public override async Task<Result<IReadOnlyList<Employee>>> Handle(GetEmployeesListQuery request, CancellationToken cancellationToken)
    //    {
    //        var spec = new GetEmployeeListQuerySpecification(request.param);
    //        return Result<IReadOnlyList<Employee>>.Success( await _uow.EmployeeRepository.GetAllAsync(spec));
    //    }
    //}
  


}
