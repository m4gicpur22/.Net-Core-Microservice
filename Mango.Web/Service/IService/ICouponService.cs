using Mango.Web.Models;
using System.Reflection;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);

        Task<ResponseDto?> GetAllCouponsAsync();

        Task<ResponseDto?> GetCouponByIdAsync(int couponId);

        Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);

        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);

        Task<ResponseDto?> DeleteCouponAsync(int couponId);
    }
}
