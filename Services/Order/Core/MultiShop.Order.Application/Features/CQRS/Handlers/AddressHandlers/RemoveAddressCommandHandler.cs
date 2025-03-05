using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class RemoveAddressCommandHandler(IRepository<Address> repo)
{
    public async Task Handle(RemoveAddressCommand command)
    {
        var value = await repo.GetByIdAsync(command.Id);
        await repo.DeleteAsync(value);
    }
}


