﻿using MangoWeb.Models;

namespace MangoWeb.Services.IServices
{
    public interface ICouponService
    {
        Task<ResponseDto> GetAllCouponAsync();
        Task<ResponseDto> GetCouponByCodeAsync(string couponCode);
        Task<ResponseDto> GetCouponByIdAsync(int couponId);
        Task<ResponseDto> CreateCouponAsync(CouponDto couponDto);
        Task<ResponseDto> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto> DeleteCouponAsync(int couponID);


    }
}
