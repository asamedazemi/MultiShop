﻿using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class CreateAddressCommandHandler
{
    private readonly IRepository<Address> _repository;

    public CreateAddressCommandHandler(IRepository<Address> repository)
    {
        _repository = repository;
    }
    public async Task Handle(CreateAddressCommand createAddressCommand, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Address
        {
            City = createAddressCommand.City,
            Detail = createAddressCommand.Detail,
            District = createAddressCommand.District,
            UserId = createAddressCommand.UserId,
        });
    }
}
