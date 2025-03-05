using MediatR;
using MultiShop.Order.Application.Features.Mediator.Command.OrderingCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers;

public class UpdateOrderingCommandHandler(IRepository<Ordering> repo) : IRequestHandler<UpdateOrderingCommand>
{
    public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
    {
        var values = await repo.GetByIdAsync(request.OrderingId);

        values.OrderDate = request.OrderDate;
        values.UserId = request.UserId;
        values.TotalPrice = request.TotalPrice;

        await repo.UpdateAsync(values);
    }
}
