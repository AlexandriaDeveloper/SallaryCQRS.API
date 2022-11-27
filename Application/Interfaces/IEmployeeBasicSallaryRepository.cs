using Domain.Models;

namespace Application.Interfaces
{
    public interface IEmployeeBasicSallaryRepository :IRepository<EmployeeBasicSallary>
    {
        Task<EmployeeBasicSallary> EmployeeGetRaise(Guid lasyEmployeeSallaryId
          , Guid newFinancialYear,
          decimal? wazifiPercentage,
          decimal? wazifiAmount,
          decimal? wazifiMinAmount,
          decimal? wazifiMaxAmount,
          decimal? mokamelPercentage,
          decimal? mokamelAmount,
          decimal? mokamelMinAmount,
          decimal? mokamelMaxAmount
          );
    }
}