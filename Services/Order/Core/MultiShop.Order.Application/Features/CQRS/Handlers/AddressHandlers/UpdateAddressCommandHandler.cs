﻿using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class UpdateAddressCommandHandler(IRepository<Address> repo)
{
    public async Task Handle(UpdateAddressCommand command)
    {
        var values = await repo.GetByIdAsync(command.AddressId);
        values.Detail = command.Detail;
        values.District = command.District;
        values.City = command.City;
        values.UserId = command.UserId;
        await repo.UpdateAsync(values);
    }
}
