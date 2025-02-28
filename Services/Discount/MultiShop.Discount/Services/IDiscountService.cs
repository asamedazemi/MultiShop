﻿using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services;

public interface IDiscountService
{
    Task<List<ResultDiscountCouponDto>> GetDiscountCouponListAsync();
    Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);
    Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);
    Task DeleteDiscountCouponAsync(int id);
    Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
}
