using Cumpom.Core.Entities.Coupon;

namespace Cumpom.Core.Abstractions
{
    public interface ICupounService
    {
        Task BuyCupoun(Couponn couponn);
        Task<Couponn> GetByIdAsync(Guid id);
        

    }
}
