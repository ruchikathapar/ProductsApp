﻿using System;

namespace RuchikaProductApp
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            if (productId < 1 || productId > 10000)
                throw new ArgumentOutOfRangeException(nameof(productId), "ProductID must be between 1 and 10000");
            if (price < 1 || price > 5000)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be between 1 and 5000");
            if (stock < 1 || stock > 100000)
                throw new ArgumentOutOfRangeException(nameof(stock), "Stock must be between 1 and 100000");

            if (string.IsNullOrWhiteSpace(productName))
                throw new ArgumentNullException(nameof(productName), "Product name cannot be null or empty");

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Increase amount must be positive");
            Stock += amount;
        }

        public void DecreaseStock(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Decrease amount must be positive");
            if (amount > Stock)
                throw new InvalidOperationException("Cannot decrease stock below zero");
            Stock -= amount;
        }
    }
}
