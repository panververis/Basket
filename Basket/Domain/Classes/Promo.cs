using Common.Enums;

namespace Basket.Domain
{
    /// <summary>
    /// Public class that represents a given promotion.
    /// Holds 4 properties describing the nature of the promotion:
    /// "Required" properties describe the Type and Quantity of Products that need to be in the basket for the Promo to be applicable.
    /// "Applicable" properties describe the Type of Product that the provided "Discount Percentage" will be applied on.
    /// </summary>
    public class Promo
    {
        #region Ctor

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public Promo(
            string          description,
            ProductTypes    requiredProductType,
            int             requiredProductQty,
            ProductTypes    applicableProductType,
            int             applicableDiscountPercentage)
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
        public ProductTypes RequiredProductType             { get; private set; }
        public int          RequiredProductQty              { get; private set; }
        public ProductTypes ApplicableProductType           { get; private set; }
        public int          ApplicableDiscountPercentage    { get; private set; }

        #endregion
    }
}
