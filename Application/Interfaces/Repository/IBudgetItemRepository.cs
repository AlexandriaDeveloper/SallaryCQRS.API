using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IBudgetItemRepository : IRepository<BudgetItem>
    {



    }

    public interface IBankRepository : IRepository<Bank>
    {



    }
    public interface IBranchRepository : IRepository<Branch>
    {



    }
    public interface IEmployeeBankRepository : IRepository<Domain.Models.EmployeeBank>
    {



    }
}
