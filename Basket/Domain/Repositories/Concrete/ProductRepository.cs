﻿using Basket.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Basket.Domain.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product GetButter()
        {
            return new Product("Super awesome butter brand", 0.80m, Common.Enums.ProductTypes.Butter);
        }

        public Product GetMilk()
        {
            return new Product("Super awesome milk brand", 1.15m, Common.Enums.ProductTypes.Milk);
        }

        public Product GetBread()
        {
            return new Product("Super awesome bread brand", 1.00m, Common.Enums.ProductTypes.Bread);
        }

        public List<Product> GetProducts(int? buttersQty, int? milksQty, int? breadsQty)
        {
            //  Guard Clause (protecting against invalid input)
            if (buttersQty <= 0 || milksQty <= 0 || breadsQty <= 0) {
                throw new Exception("Invalid input - failed to create products");
            }
            List<Product> productsList = new List<Product>();
            for (int i = 0; i < buttersQty.GetValueOrDefault(1); i++)
            {
                productsList.Add(GetButter());
            }
            for (int i = 0; i < milksQty.GetValueOrDefault(1); i++)
            {
                productsList.Add(GetMilk());
            }
            for (int i = 0; i < breadsQty.GetValueOrDefault(1); i++)
            {
                productsList.Add(GetBread());
            }
            return productsList;
        }
    }
}
