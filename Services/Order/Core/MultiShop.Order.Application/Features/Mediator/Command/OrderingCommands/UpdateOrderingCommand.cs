﻿using MediatR;

namespace MultiShop.Order.Application.Features.Mediator.Command.OrderingCommands;

public class UpdateOrderingCommand :IRequest
{
    public int OrderingId { get; set; }
    public string UserId { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }

}
