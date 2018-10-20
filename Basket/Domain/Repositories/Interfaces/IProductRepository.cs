using Basket.Domain.Classes.Concrete;
using Basket.Domain.Classes.Interfaces;
using System.Collections.Generic;

namespace Basket.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Product GetButter();
        Product GetMilk();
        Product GetBread();
        List<IProduct> GetProducts(int? buttersQty = 1, int? milksQty = 1, int? breadsQty = 1);
    }
}
