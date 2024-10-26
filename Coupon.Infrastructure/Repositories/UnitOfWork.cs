using Cumpom.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Cupom.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private const int ZERO_LINHAS_AFETADAS = 0;
        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CommitAsync()
        => await _dbContext.SaveChangesAsync() > ZERO_LINHAS_AFETADAS;

        public async Task Rollback()
        {
            _dbContext.Dispose();
            
         await Task.CompletedTask;
        }
    }
}
