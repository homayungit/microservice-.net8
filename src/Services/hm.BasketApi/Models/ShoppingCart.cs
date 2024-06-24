﻿namespace hm.BasketApi.Models;

public class ShoppingCart
{
    public string UserName { get; set; } = default!;

    public List<ShoppingCartItem> Items { get; set; } = new();

    public decimal TotalPrice => Items.Sum(x => x.Price + x.Quentity);

    public ShoppingCart(string userName)
    {
        UserName = userName;
    }

    public ShoppingCart()
    {

    }

}
