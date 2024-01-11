using Ocak.Services.ShoppingCartAPI.Models.Dto;

namespace Ocak.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
