using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repo)
{
    public async Task Handle(UpdateOrderDetailCommand command)
    {
        var values = await repo.GetByIdAsync(command.OrderDetailId);
        values.OrderingId = command.OrderingId;
        values.ProductId = command.ProductId;
        values.ProductPrice = command.ProductPrice;
        values.ProductName = command.ProductName;
        values.ProductAmount = command.ProductAmount;
        values.ProductTotalAmount = command.ProductTotalAmount;

        await repo.UpdateAsync(values);
    }
}
