using Common.Enums;
using System.Collections.Generic;

namespace Basket.Domain.Classes.Interfaces
{
    public interface IPromo {
        string          Description                     { get; }
        ProductType     RequiredProductType             { get; }
        int             RequiredProductQty              { get; }
        ProductType     ApplicableProductType           { get; }
        int             ApplicableDiscountPercentage    { get; }
        decimal         Deduction                       { get; }
        decimal CalculateDeduction(IEnumerable<IProduct> productsEnumerable);
    }
}
