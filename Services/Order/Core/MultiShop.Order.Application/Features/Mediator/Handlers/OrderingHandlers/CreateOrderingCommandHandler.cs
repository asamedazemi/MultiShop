using MediatR;
using MultiShop.Order.Application.Features.Mediator.Command.OrderingCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers;


public class CreateOrderingCommandHandler(IRepository<Ordering> repo) : IRequestHandler<CreateOrderingCommand>
{
    public async Task Handle(CreateOrderingCommand request, CancellationToken cancellationToken)
    {
        await repo.CreateAsync(new Ordering
        {
            OrderDate = request.OrderDate,
            TotalPrice = request.TotalPrice,
            UserId = request.UserId,
        });
    }
}

