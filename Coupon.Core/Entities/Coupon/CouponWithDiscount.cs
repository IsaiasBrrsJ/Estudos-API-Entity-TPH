using Cumpom.Core.Enums;

namespace Cumpom.Core.Entities.Coupon
{
    public class CouponWithDiscount : Couponn
    {
        private const decimal ClientPremium = 0.10m;
        private const decimal ClientGold = 0.6m;
        private const decimal ClientPlatinum = 0.4m;
        private const decimal Student = 0.50m;

        public void ApplyDescount(TypeClient typeClient)
        {
            switch (typeClient)
            {
                case TypeClient.Student:
                    Price = Price - ((Price * Student) / 100);
                    break;
                case TypeClient.ClientGold:
                    Price = Price - ((Price * ClientGold) / 100);
                    break;
                case TypeClient.ClientPlatinum:
                    Price = Price - ((Price * ClientPlatinum) / 100);
                    break;
                case TypeClient.ClientPremium:
                    Price = Price - ((Price * ClientPremium) / 100);
                    break;
                default:
                    break;
            }
        }
        public static class Factories
        {
            public static CouponWithDiscount CouponApplyDescount(int amount, decimal price, CouponType couponType, Guid clientId)
            {
                return new CouponWithDiscount
                {
                    Id = Guid.NewGuid(),
                    Amount = amount,
                    Price = price,
                    CouponIsUsed = true,
                    ValidCoupon = DateTime.Now.AddDays(10),
                    CouponType = couponType,
                    IssueDate = DateTime.Now,
                    ClientId = clientId
                };
             }
            
        }
    }
}
