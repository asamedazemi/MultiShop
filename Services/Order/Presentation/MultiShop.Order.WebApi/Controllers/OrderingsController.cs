using MediatR;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Order.Application.Features.Mediator.Command.OrderingCommands;
using MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries;

namespace MultiShop.Order.WebApi.Controllers;

public class OrderingsController(IMediator mediator) : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> OrderDetailList()
    {
        var values = await mediator.Send(new GetOrderingQuery());
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderingById(int id)
    {
        var values = await mediator.Send(new GetOrderingByIdQuery(id));
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrdering(CreateOrderingCommand command)
    {
        await mediator.Send(command);
        return Ok("Sipariş başarıyla eklendi.");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateOrdering(UpdateOrderingCommand command)
    {
        await mediator.Send(command);
        return Ok("Sipariş başarıyla güncellendi");
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveOrdering(int id)
    {
        await mediator.Send(new RemoveOrderingCommand(id));
        return Ok("Sipariş başarıyla silinmiştir.");
    }
}
