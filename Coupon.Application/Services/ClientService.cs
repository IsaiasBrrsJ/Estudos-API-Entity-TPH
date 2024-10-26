using Cumpom.Core.Abstractions;
using Cumpom.Core.Entities.Client.Coupon;
using Cumpom.Core.Repositories;

namespace Cumpom.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepositories _clientRepositories;
        private readonly IUnitOfWork _unitOfWork;
        public ClientService(IClientRepositories clientRepositories, IUnitOfWork unitOfWork)
        {
            _clientRepositories = clientRepositories;
            _unitOfWork = unitOfWork;
        }
        public async Task AddClientAsync(Clientt clientt)
        {
          await _clientRepositories.AddClientAsync(clientt);

          await _unitOfWork.CommitAsync();
        }
        public Task<Clientt> GetClientByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task LogicalDeleteAsync(Clientt clientt)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(Clientt clientt)
        {
            throw new NotImplementedException();
        }
    }
}
