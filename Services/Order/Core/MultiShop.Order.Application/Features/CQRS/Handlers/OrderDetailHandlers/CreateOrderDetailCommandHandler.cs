using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class CreateOrderDetailCommandHandler(IRepository<OrderDetail> repo)
{
    public async Task Handle(CreateOrderDetailCommand command)
    {
        await repo.CreateAsync(new OrderDetail
        {
            ProductAmount=command.ProductAmount,
            OrderingId=command.OrderingId,
            ProductId=command.ProductId,
            ProductName=command.ProductName,
            ProductPrice=command.ProductPrice,
            ProductTotalAmount=command.ProductTotalAmount,
        });
    }
}
