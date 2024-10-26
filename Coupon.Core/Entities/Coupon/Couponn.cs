using Cumpom.Core.Entities.Client.Coupon;
using Cumpom.Core.Enums;

namespace Cumpom.Core.Entities.Coupon
{
    public abstract class Couponn : EntityBase
    {
        //ef
        public Couponn()
        {
            
        }
        public CouponType CouponType { get; init; }
        public DateTime IssueDate { get; init; }
        public decimal Price { get; protected set; }
        public int Amount { get; init; }
        public Clientt Client { get; private set; }
        public Guid ClientId { get; protected set; }    
        public bool CouponIsUsed {  get; protected set; }  
        public DateTime ValidCoupon {  get; protected set; }
        
    }
}
