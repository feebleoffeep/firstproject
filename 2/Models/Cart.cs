﻿using _2.Models;

public class Cart
{
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        var existingItem = Items.FirstOrDefault(p => p.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            Items.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }

    public decimal GetTotalPrice()
    {
        return Items.Sum(i => i.Product.Price * i.Quantity);
    }
}

public class CartItem
{
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}





