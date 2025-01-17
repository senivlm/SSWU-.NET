﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTask
{
    public class Buy
    {
        public int ProductsAmount { get; set; }
        public int TotalPrice { get; set; }
        public double TotalWeight { get; set; }
        public List<Product> AllProducts { get; set; }
        public Buy(params Product[] products)
        {
            ProductsAmount = products.Length;
            AllProducts = new List<Product>();
            foreach (var item in products)
            {
                TotalPrice += item.Price;
                TotalWeight += item.Weight;
                AllProducts.Add(item);
            }
        }
        public Buy() 
        {

        }
        public void AddProduct(Product product)
        {
            if (product != null)
            {
                AllProducts.Add(product);
                TotalPrice += product.Price;
                TotalWeight += product.Weight;
                ProductsAmount += 1;
            }
        }
    }
}
