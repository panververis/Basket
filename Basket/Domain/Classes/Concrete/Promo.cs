using System;
using System.Collections.Generic;
using System.Linq;
using Basket.Domain.Classes.Interfaces;
using Common;
using Common.Enums;

namespace Basket.Domain.Classes.Concrete
{
    /// <summary>
    /// Public class that represents a given promotion.
    /// Holds 4 properties describing the nature of the promotion:
    /// "Required" properties describe the Type and Quantity of Products that need to be in the basket for the Promo to be applicable.
    /// "Applicable" properties describe the Type of Product that the provided "Discount Percentage" will be applied on.
    /// </summary>
    /// <remarks>
    /// This class is a good example of how the Strategy pattern can be used, whereas each Promo is a deduction-calculating strategy
    /// </remarks>
    public class Promo : IPromo
    {
        #region Ctor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public Promo(
            string                          description,
            ProductType                     requiredProductType,
            int                             requiredProductQty,
            ProductType                     applicableProductType,
            int                             applicableDiscountPercentage)
        {
            Description                     = description;
            RequiredProductType             = requiredProductType;
            RequiredProductQty              = requiredProductQty;
            ApplicableProductType           = applicableProductType;
            ApplicableDiscountPercentage    = applicableDiscountPercentage;
        }

        #endregion

        #region Properties

        public string       Description                     { get; private set; }
        public ProductType  RequiredProductType             { get; private set; }
        public int          RequiredProductQty              { get; private set; }
        public ProductType  ApplicableProductType           { get; private set; }
        public int          ApplicableDiscountPercentage    { get; private set; }
        public decimal      Deduction                       { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Applies the promo appropriately, looking into the provided as input List of Products
        /// </summary>
        /// <param name="products">This is the List of Products (normally provided to it by the Basket which holds them)</param>
        /// <returns></returns>
        public decimal CalculateDeduction(IEnumerable<IProduct> products) {
            //  Calculates the Deduction (if applicable)
            if (products != null && products.Any()) {
                int timesOfPromoApplication = (int)Math.Floor((decimal)(products.Count(x => x.ProductType == RequiredProductType) / RequiredProductQty));
                IProduct applicableProduct = products.FirstOrDefault(x => x.ProductType == ApplicableProductType);
                if (applicableProduct != null) {
                    Deduction = timesOfPromoApplication * Math.Round(applicableProduct.Price * ApplicableDiscountPercentage / 100, CommonTestInfo.RoundingPoints);
                }
            }
            return Deduction;
        }

        #endregion
    }
}
