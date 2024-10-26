using Cumpom.Application.InputModels;
using Cumpom.Core.Abstractions;
using Cumpom.Core.Entities.Coupon;
using Microsoft.AspNetCore.Mvc;

namespace Cupom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICupounService _couponService;
        public CouponController(ICupounService couponService)
        {
            _couponService = couponService;
        }

        [HttpPost("Add-Coupon")]
        public async Task<IActionResult> AddCoupon([FromBody] CouponInputModel coupon)
        {
            var couponToEntity = CouponWithDiscount
                .Factories
                .CouponApplyDescount(coupon.amount, coupon.price, coupon.CouponType, coupon.ClientId);


             await _couponService.BuyCupoun(couponToEntity);

            return Ok();
        }
    }
}
