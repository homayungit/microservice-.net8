namespace hm.BasketApi.Basket.GetBasket;

public record GetBasketQuery(string UserName) : IQuery<GetBusketResult>;

public record GetBusketResult(ShoppingCart Cart);

public class GetBasketQueryHendler : IQueryHandler<GetBasketQuery, GetBusketResult>
{
    public async Task<GetBusketResult> Handle(GetBasketQuery request, CancellationToken cancellationToken)
    {
        return new GetBusketResult(new ShoppingCart("swn"));
    }
}
