using MangoWeb.Models;
using MangoWeb.Services.IServices;

namespace MangoWeb.Services
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto> CreateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = Constants.ApiType.POST,
                Data = couponDto,
                ApiUrl = Constants.CouponAPIBase + "/api/couponApi"
            });
        }

        public async Task<ResponseDto> DeleteCouponAsync(int couponID)
        {
            return await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = Constants.ApiType.DELETE,
                ApiUrl = Constants.CouponAPIBase + "/api/couponApi/" + couponID
            });
        }

        public async Task<ResponseDto> GetAllCouponAsync()
        {
            return await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = Constants.ApiType.GET,
                ApiUrl = Constants.CouponAPIBase + "/api/couponApi"
            });
        }

        public async Task<ResponseDto> GetCouponByCodeAsync(string couponCode)
        {
            return await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = Constants.ApiType.GET,
                ApiUrl = Constants.CouponAPIBase + "/api/couponApi/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto> GetCouponByIdAsync(int couponId)
        {
            return await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = Constants.ApiType.GET,
                ApiUrl = Constants.CouponAPIBase + "/api/couponApi/" + couponId
            });
        }

        public async Task<ResponseDto> UpdateCouponAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new ApiRequest()
            {
                ApiType = Constants.ApiType.PUT,
                Data = couponDto,
                ApiUrl = Constants.CouponAPIBase + "/api/couponApi"
            });
        }
    }
}
