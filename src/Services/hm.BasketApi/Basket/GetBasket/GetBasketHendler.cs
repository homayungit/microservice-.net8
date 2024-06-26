using hm.BasketApi.Data;

namespace hm.BasketApi.Basket.GetBasket;

public record GetBasketQuery(string UserName) : IQuery<GetBusketResult>;

public record GetBusketResult(ShoppingCart Cart);

public class GetBasketQueryHendler(IBasketRepository repository) : IQueryHandler<GetBasketQuery, GetBusketResult>
{
    public async Task<GetBusketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        var basket = await repository.GetBasket(query.UserName);
        return new GetBusketResult(basket);
    }
}
