using Basket.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basket.Domain.Classes
{
    public class GroceriesBasket
    {
        #region Ctor

        public GroceriesBasket(IPromoRepository promoRepository, IProductRepository productRepository)
        {
            PromoRepo       = promoRepository;
            ProductRepo     = productRepository;
            ProductsList    = new List<Product>();
            PromosList      = new List<Promo>();
        }

        #endregion

        #region Properties

        private IPromoRepository    PromoRepo           { get; set; }
        private IProductRepository  ProductRepo         { get; set; }
        public  List<Product>       ProductsList        { get; private set; }
        public  List<Promo>         PromosList          { get; private set; }
        public  decimal             TotalCost           { get; private set; }
        public  decimal             PromoDeductions     { get; private set; }
        public  decimal             FinalCost           { get; private set; }

        #endregion

        #region Methods (Not yet implemented)

        public void AddButter()
        {
            Product butter = ProductRepo.GetButter();
            ProductsList.Add(butter);
        }

        public void AddMilk()
        {
            Product milk = ProductRepo.GetMilk();
            ProductsList.Add(milk);
        }

        public void AddBread()
        {
            Product bread = ProductRepo.GetBread();
            ProductsList.Add(bread);
        }

        public void AddProducts(int buttersQty, int milksQty, int breadsQty)
        {
            List<Product> productsList = ProductRepo.GetProducts(buttersQty, milksQty, breadsQty);
            ProductsList = productsList;
        }

        public void AddPromos() {
            List<Promo> promosList = new List<Promo>();
            promosList.Add(PromoRepo.GetPromoOne());
            promosList.Add(PromoRepo.GetPromoTwo());
            PromosList = promosList;
        }

        /// <summary>
        /// Step 1. Calculate the Total Cost.
        /// Step 2. Calculate the Sum of the Promo Deductions, as per the number of Active & Applicable Promos
        /// Step 3. Subtract the Promo Deductions from the Total Cost, thus the Final Cost is calculated!
        /// </summary>
        public void CalculateFinalCost() {
            //  Guard Clause (exit if products are null or empty)
            if (ProductsList == null || !ProductsList.Any()) {
                return;
            }

            //  Step 1. Total Cost
            TotalCost = ProductsList.Sum(x => x.Price);

            //  Step 2. Promo Deductions
            if (PromosList == null || !PromosList.Any()) {
                return;
            }
            foreach (Promo promo in PromosList) {
                int timesOfPromoApplication = (int)Math.Floor((decimal)(ProductsList.Count(x => x.ProductType == promo.RequiredProductType) / promo.RequiredProductQty));
                Product applicableProduct = ProductsList.FirstOrDefault(x => x.ProductType == promo.ApplicableProductType);
                if (applicableProduct != null) {
                    decimal promoDeduction = timesOfPromoApplication * Math.Round(applicableProduct.Price*promo.ApplicableDiscountPercentage/100, 2);
                    PromoDeductions += promoDeduction;
                }
            }

            //  Step 3. Final Cost
            FinalCost = TotalCost - PromoDeductions;
        }

        #endregion
    }
}
