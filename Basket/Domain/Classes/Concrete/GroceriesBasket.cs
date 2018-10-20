using Basket.Domain.Classes.Interfaces;
using System.Collections.Generic;

namespace Basket.Domain.Classes.Concrete
{
    public class GroceriesBasket : IGroceriesBasket
    {
        #region Ctor

        public GroceriesBasket() {
            ProductsList    = new List<IProduct>();
        }

        #endregion

        #region Properties

        public  List<IProduct>       ProductsList        { get; private set; }

        #endregion

        #region Methods

        public void AddProduct(IProduct product) {
            ProductsList.Add(product);
        }

        public void AddProducts(List<IProduct> productsList) {
            ProductsList = productsList;
        }

        #endregion
    }
}
