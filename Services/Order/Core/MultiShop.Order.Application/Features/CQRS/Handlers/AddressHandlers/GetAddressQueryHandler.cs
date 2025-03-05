using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;

public class GetAddressQueryHandler(IRepository<Address> repo)
{
    public async Task<List<GetAddressQueryResult>> Handle()
    {
        var values = await repo.GetAllAsync();
        return values.Select(x => new GetAddressQueryResult
        {
            AddressId = x.AddressId,
            City = x.City,
            Detail = x.Detail,
            District = x.District,
            UserId = x.UserId
        }).ToList();
    }
}
