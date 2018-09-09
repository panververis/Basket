using Basket.Domain.Repositories.Interfaces;
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

        public IEnumerable<Product> GetProducts(int? buttersQty, int? milksQty, int? breadsQty)
        {
            throw new NotImplementedException();
        }
    }
}
