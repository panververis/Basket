using System.Collections.Generic;

namespace Basket.Domain.Repositories.Interfaces
{
    interface IProductRepository
    {
        Product GetButter();
        Product GetMilk();
        Product GetBread();
        IEnumerable<Product> GetProducts(int? buttersQty, int? milksQty, int? breadsQty);
    }
}
