using Cumpom.Core.Entities.Client.Coupon;
using Cumpom.Core.Repositories;

namespace Cupom.Infrastructure.Repositories
{
    public class ClientRepositories : IClientRepositories
    {
        private readonly DbContextCp _dbContextCp;
        public ClientRepositories(DbContextCp dbContextCp)
        {
            _dbContextCp = dbContextCp;
        }
        public async Task AddClientAsync(Clientt clientt)
        {
            await _dbContextCp.AddAsync(clientt);
        }
    }
}
