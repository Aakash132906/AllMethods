using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Infrastructure.Persistence;
using PersonalWork.Infrastructure.Persistence.Repositories;
using PersonalWork.Infrastructure.DevDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FtoysContext _context;



        public UnitOfWork(FtoysContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }



        public IRepository<T> GetReposiotory<T>() where T : class
        {
            return new Repository<T>(_context);
        }



        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
