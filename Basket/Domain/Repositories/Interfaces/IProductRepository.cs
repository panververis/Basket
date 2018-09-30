using Basket.Domain.Classes.Concrete;
using System.Collections.Generic;

namespace Basket.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetButter();
        Product GetMilk();
        Product GetBread();
        List<Product> GetProducts(int? buttersQty = 1, int? milksQty = 1, int? breadsQty = 1);
    }
}
