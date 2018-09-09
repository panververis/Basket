using Basket.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace Basket.Domain.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product GetBread()
        {
            throw new NotImplementedException();
        }

        public Product GetButter()
        {
            throw new NotImplementedException();
        }

        public Product GetMilk()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts(int? buttersQty, int? milksQty, int? breadsQty)
        {
            throw new NotImplementedException();
        }
    }
}
