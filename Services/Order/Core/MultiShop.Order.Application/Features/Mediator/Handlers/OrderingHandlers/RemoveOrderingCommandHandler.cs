using MediatR;
using MultiShop.Order.Application.Features.Mediator.Command.OrderingCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers;


public class RemoveOrderingCommandHandler(IRepository<Ordering> repo) : IRequestHandler<RemoveOrderingCommand>
{
    public async Task Handle(RemoveOrderingCommand request, CancellationToken cancellationToken)
    {
        var values = await repo.GetByIdAsync(request.Id);
        await repo.DeleteAsync(values);
    }
}
