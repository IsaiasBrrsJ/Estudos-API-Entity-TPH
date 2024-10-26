using Cumpom.Core.Enums;

namespace Cumpom.Application.InputModels
{
    public class CouponInputModel
    {
        public CouponType CouponType { get; set; }
        public Guid ClientId { get;  set; }
        public int amount { get; set; }
        public decimal price { get; set; }
    }
}
