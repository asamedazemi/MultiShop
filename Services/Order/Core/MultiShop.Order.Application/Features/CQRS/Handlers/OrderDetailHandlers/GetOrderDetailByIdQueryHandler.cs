﻿using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repo)
{
    public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
    {
        var values = await repo.GetByIdAsync(query.Id);
        return new GetOrderDetailByIdQueryResult
        {
            OrderDetailId = values.OrderDetailId,
            ProductAmount = values.ProductAmount,
            ProductId = values.ProductId,
            ProductName = values.ProductName,
            OrderingId = values.OrderingId,
            ProductPrice = values.ProductPrice,
            ProductTotalAmount = values.ProductTotalAmount
        };
    }

}
