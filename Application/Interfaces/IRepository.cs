using Domain.Primitives;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<PagedList<T>> GetAllBySpecAsync(ISpecification<T>? spec = null, bool trackingChanges = true);
        Task<T> GetByIdAsync(int id);
        Task<bool> CheckExistAsync(int id);
        Task<T?> GetByNameAsync(string name);
        Task<T?> GetByAsync(Expression<Func<T, bool>> expression);
        bool CheckByAsync(Expression<Func<T, bool>> expression);
        Task<int?> Next(Expression<Func<T, int>> orderBy, int id);
        Task<int?> Previous(Expression<Func<T, int>> orderBy, int id);
        Task<PagedList<T>> GetBySingleOrDefaultAsync(ISpecification<T>? spec = null, bool trackChanges = true);

        Task AddItem(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<int> CountAsync(ISpecification<T> spec);

        Task<PagedList<T>> GetAlDeletedlAsync( ISpecification<T>? spec = null, bool trackingChanges = true);
        Task Restore(int id);

    }
}
