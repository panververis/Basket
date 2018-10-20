using Basket.Domain.Classes.Interfaces;
using Common.Enums;

namespace Basket.Domain.Classes.Concrete
{
    public class Product : IProduct
    {
        #region Ctor

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        public Product(string name, decimal price, ProductType productType) {
            Name        = name;
            Price       = price;
            ProductType = productType;
        }

        #endregion

        #region Properties

        public string       Name        { get; private set; }
        public decimal      Price       { get; private set; }
        public ProductType  ProductType { get; private set; }

        #endregion
    }
}
