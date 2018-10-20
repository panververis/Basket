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
        //public  decimal             TotalCost           { get; private set; }
        //public  decimal             PromoDeductions     { get; private set; }
        //public  decimal             FinalCost           { get; private set; }

        #endregion

        #region Methods

        public void AddProduct(IProduct product) {
            ProductsList.Add(product);
        }

        public void AddProducts(List<IProduct> productsList) {
            ProductsList = productsList;
        }

        ///// <summary>
        ///// Step 1. Calculate the Total Cost.
        ///// Step 2. Calculate the Sum of the Promo Deductions, as per the number of Active & Applicable Promos
        ///// Step 3. Subtract the Promo Deductions from the Total Cost, thus the Final Cost is calculated!
        ///// </summary>
        //public void CalculateFinalCost() {
        //    //  Guard Clause (exit if products are null or empty)
        //    if (ProductsList == null || !ProductsList.Any()) {
        //        return;
        //    }

        //    //  Step 1. Total Cost
        //    TotalCost = ProductsList.Sum(x => x.Price);

        //    //  Step 2. Promo Deductions
        //    if (PromosList == null || !PromosList.Any()) {
        //        return;
        //    }
        //    foreach (Promo promo in PromosList) {
        //        int timesOfPromoApplication = (int)Math.Floor((decimal)(ProductsList.Count(x => x.ProductType == promo.RequiredProductType) / promo.RequiredProductQty));
        //        Product applicableProduct = ProductsList.FirstOrDefault(x => x.ProductType == promo.ApplicableProductType);
        //        if (applicableProduct != null) {
        //            decimal promoDeduction = timesOfPromoApplication * Math.Round(applicableProduct.Price*promo.ApplicableDiscountPercentage/100, CommonTestInfo.RoundingPoints);
        //            PromoDeductions += promoDeduction;
        //        }
        //    }

        //    //  Step 3. Final Cost
        //    FinalCost = TotalCost - PromoDeductions;
        //}

        #endregion
    }
}
