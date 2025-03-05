using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

public class RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repo)
{
    public async Task Handle(RemoveOrderDetailCommand command)
    {
        var value = await repo.GetByIdAsync(command.Id);
        await repo.DeleteAsync(value);
    }
}
