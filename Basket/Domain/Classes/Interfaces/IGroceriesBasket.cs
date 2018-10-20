using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Domain.Classes.Interfaces
{
    public interface IGroceriesBasket
    {
        List<IProduct> ProductsList { get; }
        void AddProduct(IProduct product);
        void AddProducts(List<IProduct> productsList);
    }
}
