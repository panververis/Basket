﻿using Basket.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basket.Domain.Classes
{
    public class GroceriesBasket
    {
        #region Ctor

        public GroceriesBasket(IPromoRepository promoRepository, IProductRepository productRepository)
        {
            PromoRepo   = promoRepository;
            ProductRepo = productRepository;
        }

        #endregion

        #region Properties

        private IPromoRepository    PromoRepo          { get; set; }
        private IProductRepository  ProductRepo        { get; set; }
        public  List<Product>      ProductsList        { get; private set; }
        public  List<Promo>        PromosList          { get; private set; }
        public  decimal            TotalCost           { get; private set; }
        public  decimal            PromoDeductions     { get; private set; }
        public  decimal            FinalCost           { get; private set; }

        #endregion

        #region Methods (Not yet implemented)

        public void AddButter()
        {
            throw new Exception("Not yet implemented");
        }

        public void AddMilk()
        {
            throw new Exception("Not yet implemented");
        }

        public void AddBread()
        {
            throw new Exception("Not yet implemented");
        }

        public void AddProducts(int buttersQty, int milksQty, int breadsQty)
        {
            throw new Exception("Not yet implemented");
        }

        public void CalculateFinalCost()
        {
            throw new Exception("Not yet implemented");
        }

        #endregion
    }
}