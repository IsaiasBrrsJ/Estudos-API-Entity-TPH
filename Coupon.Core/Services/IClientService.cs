using Cumpom.Core.Entities.Client.Coupon;

namespace Cumpom.Core.Abstractions
{
    public interface IClientService
    {
        Task AddClientAsync(Clientt clientt);
        Task<Clientt> GetClientByIdAsync(Guid id);
        Task UpdateAsync(Clientt clientt);
        Task LogicalDeleteAsync(Clientt clientt);
    }
}
