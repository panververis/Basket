using System.Collections.Generic;

namespace Basket.Domain.Classes.Interfaces
{
    interface IPromo {
        decimal CalculateDeduction(IEnumerable<IProduct> productsEnumerable);
    }
}
