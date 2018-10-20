using Basket.Domain.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Basket.Domain.Classes.Concrete
{
    public class CostCalculator : ICostCalculator
    {
        #region Properties

        public decimal          TotalCost           { get; private set; }
        public decimal          PromosDeductions    { get; private set; }
        public decimal          FinalCost           { get; private set; }
        public List<IPromo>     PromosList          { get; private set; }
        public IGroceriesBasket Basket              { get; private set; }

        #endregion

        #region Ctor

        public CostCalculator(IGroceriesBasket groceriesbasket, List<IPromo> promosList) {
            Basket      = groceriesbasket;
            PromosList  = promosList;
        }

        #endregion

        #region Methods

        #region Public methods

        public void CalculateCosts() {
            //  Guard clause (checking for null or empty)
            if (Basket == null) {
                throw new ArgumentException($"Unable to calculate basket's cost, because the {nameof(Basket)} is null");
            }

            //  Firstly, calculate the "Initial" total cost
            CalculateTotalCost();

            //  Then, calculate the Deductions that should be applied by the Promos (if any are applicable)
            CalculatePromosDeductions();

            //  Lastly, calculate the Final Cost that the client has to pay after the Promos have been applied
            CalculateFinalCost();
        }

        #endregion

        #region Private (helper) methods

        private void CalculateTotalCost() {
            if (Basket.ProductsList == null || !Basket.ProductsList.Any()) {
                return;
            }
            Basket.ProductsList.ForEach(product => TotalCost += product.Price);
        }

        private void CalculatePromosDeductions() {
            if (PromosList == null || !PromosList.Any()) {
                return;
            }
            PromosList.ForEach(promo => PromosDeductions += promo.CalculateDeduction(Basket.ProductsList));
            if (PromosDeductions < 0) {
                throw new Exception("Promo deduction calculations have returned a positive number");
            }
        }

        private void CalculateFinalCost() {
            FinalCost = TotalCost - PromosDeductions;
            if (FinalCost < 0) {
                throw new Exception("Final cost calculation has returned a negative number");
            }
        }

        #endregion

        #endregion
    }
}
