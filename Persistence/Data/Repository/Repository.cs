using Application.DTOS;
using Application.Interfaces;
using Azure;
using Domain.Primitives;
using Microsoft.EntityFrameworkCore;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;
        private readonly DbSet<T>   _dbSet;
     
        public Repository(SallaryCQRSAppContext context,IAuthService authService )
        {
            this._context = context;
            this._authService = authService;
            this._dbSet = context.Set<T>();

        }
        public async Task AddItem(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.CreatedDate = DateTime.UtcNow;
            entity.CreatedBy = _authService.GetCurrentLoggedInUser();
             await  _dbSet.AddAsync(entity);
       
        }

        public async Task Delete(int id)
        {
           var entity = await GetByIdAsync(id);
            if(entity == null)
                throw new ArgumentNullException();
            if (entity.IsDeleted)
            {
                throw new Exception("Not Found");
            }
            entity.DeletedDate = DateTime.Now;
            entity.DeletedBy = _authService.GetCurrentLoggedInUser();
            _dbSet.Update(entity);
         
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(ISpecification<T>? spec = null)
        {
            if (spec == null) { 
            return await _dbSet.ToListAsync();
            }
          return await ApplySpecification(spec).ToListAsync() ;       
        }
        //public async Task<IPagination< T>> GetAllPaginatedAsync(IParam? param, ISpecification<T>? spec = null)
        //{
        //    IPagination<T> result;

        //    if (spec == null)
        //    {
        //      result= await Pagination<T>.CreateAsync(_dbSet.AsQueryable(),param.PageIndex,
        //          param.PageSize);
        //    }
        //     result = await Pagination<T>.CreateAsync(ApplySpecification(spec).AsQueryable(), param.PageIndex,
        //          param.PageSize);

          
        //    return result;

        //}
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x=> x.Id== id);
        }
        public async Task<T?> GetByNameAsync(string name)
        {
            return await _dbSet.SingleOrDefaultAsync(x => x.Name == name);
        }
        public async Task<T> GetBySingleOrDefaultAsync(ISpecification<T>? spec = null)
        {
            return await ApplySpecification(spec).SingleOrDefaultAsync();
        }
     
        public Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.ModifiedDate = DateTime.UtcNow;
            entity.ModifiedBy = _authService.GetCurrentLoggedInUser();
            _dbSet.Update(entity);
            return Task.CompletedTask;
        }
        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbSet.Where(x => x.DeletedDate==null).AsQueryable(), spec); ;
        }
        public async Task<IReadOnlyList<T>> GetAlDeletedlAsync(ISpecification<T>? spec = null)
        {
           
                return await ApplyDeletedSpecification(spec).ToListAsync();
 
        }
        public async Task Restore(int id)
        {
            var entity = await GetByIdAsync(id);
            
            if (entity == null)
                throw new ArgumentNullException();
            if (!entity.IsDeleted) {
                throw new Exception("Not Found");
            }
            entity.DeletedDate =null;
            entity.DeletedBy = null;
            _dbSet.Update(entity);

        }
        private IQueryable<T> ApplyDeletedSpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbSet.Where(x => x.DeletedDate != null).AsQueryable(), spec); ;
        }
    }
}
