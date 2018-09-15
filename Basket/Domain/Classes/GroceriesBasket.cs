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
        /// Firstly we calculate the Total Cost.
        /// Next we calculate the Sum of the Promo Deductions, as per the number of Active & Applicable Promos
        /// Lastly we subtract the Promo Deductions from the Total Cost, thus the Final Cost is calculated
        /// </summary>
        public void CalculateFinalCost() {
            throw new Exception("Not yet implemented");
        }

        #endregion
    }
}
