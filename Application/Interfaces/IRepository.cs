using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<IReadOnlyList<T>> GetAllAsync(ISpecification<T>? spec=null);
        Task<T> GetByIdAsync(Guid id);
        Task<T> GetBySingleOrDefaultAsync(ISpecification<T>? spec = null);

        Task AddItem(T entity);
        Task Update(T entity);
        Task Delete(Guid id);
        Task<int> CountAsync(ISpecification<T> spec);

        Task<IReadOnlyList<T>> GetAlDeletedlAsync(ISpecification<T>? spec = null);
        Task Restore(Guid id);

    }
}
