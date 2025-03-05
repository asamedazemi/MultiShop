using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class GetAddressByIdQueryHandler(IRepository<Address> repo)
{
    public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
    {
        var values = await repo.GetByIdAsync(query.Id);
        return new GetAddressByIdQueryResult
        {
            AddressId = values.AddressId,
            City = values.City,
            Detail = values.Detail,
            District = values.District,
            UserId = values.UserId,
        };
    }
}
