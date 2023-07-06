using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Application.Common.Models;
using PersonalWork.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PersonalWork.Application.Command.Users.LoginUser;

namespace PersonalWork.Infrastructure.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> GetAsync(object id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> GetByAsync(Expression<Func<TEntity, bool>> predicate, bool includeAll = false)
        {
            if (includeAll)
                return await Context.Set<TEntity>().IncludeAll().FirstOrDefaultAsync(predicate);

            return await Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public async Task<TEntity> GetByMostRecentAsync(Expression<Func<TEntity, bool>> predicate, bool includeAll = false)
        {
            if (includeAll)
                return await Context.Set<TEntity>().IncludeAll().Where(predicate).OrderByDescending(x => "Id").FirstOrDefaultAsync();

            return await Context.Set<TEntity>().Where(predicate).OrderByDescending(x => "Id").FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(bool includeAll = false)
        {
            if (includeAll)
                return await Context.Set<TEntity>().IncludeAll().ToListAsync();

            return await Context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool includeAll = false)
        {
            if (includeAll)
                return await Context.Set<TEntity>().IncludeAll().Where(predicate).ToListAsync();
            return await Context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetReportListAsync(Expression<Func<TEntity, bool>> predicate, bool includeAll = false)
        {
            if (includeAll)
                return await Context.Set<TEntity>().IncludeAll().Where(predicate).OrderByDescending(x => "repoton").ToListAsync();
            return await Context.Set<TEntity>().Where(predicate).OrderByDescending(x => "repoton").ToListAsync();
        }

        public async Task<BaseResult<TEntity>> GetPagingListAsync(int page, int perPage, bool includeAll = false)
             => await getPagingListAsync(page, perPage, null, includeAll);

        public async Task<BaseResult<TEntity>> GetPagingListAsync(BaseRequest filters, bool includeAll = false)
             => await getPagingListAsync(filters.Page, filters.PerPage, filters.Filter, includeAll);

        public async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().Where(predicate).CountAsync();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        private async Task<BaseResult<TEntity>> getPagingListAsync(int page, int perPage, List<Where> filter, bool includeAll)
        {
            var dbset = Context.Set<TEntity>();
            var query = dbset.AsQueryable();
            if (includeAll)
                query = dbset.IncludeAll();

            if (filter != null)
                query = query.Where(DynamicWhereFilter.Where<TEntity>(filter));

            if (page < 1) page = 1;
            var count = await query.CountAsync();
            if (includeAll) perPage = count;
            var result = await query.Skip((page - 1) * perPage).Take(perPage).ToListAsync();

            return new BaseResult<TEntity>
            {
                Data = result,
                CurrPage = page,
                Total = count,
                PerPage = perPage
            };
        }

        public async Task<IEnumerable<TEntity>> GetSPResult(string query)
        {
            var result = await Context.Set<TEntity>().FromSqlRaw(query).ToListAsync();
            return result;
        }

        public async Task<SPSuccess> ExecSP(string query)
        {
            var result = Context.Database.ExecuteSqlRaw(query);
            Context.SaveChanges();
            if (result > 0)
                return new SPSuccess() { success = 1 };
            return new SPSuccess() { success = 0 };
        }

        public async Task<int> ExecuteWithStoreProcedureAsync(string query, params object[] parameters)
        {
            return await Context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public Task GetByAsync(int id, string userToken)
        {
            throw new NotImplementedException();
        }

        public object AddAsync(LoginUserCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
