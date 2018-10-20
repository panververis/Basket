using Basket.Domain.Classes.Concrete;
using Basket.Domain.Classes.Interfaces;
using Basket.Domain.Repositories.Concrete;
using Basket.Domain.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Basket.Tests.CostCalculatorTests
{
    /// <summary>
    /// This is essentially the class that performs the calculation as per the Tests describe
    /// </summary>
    public class CostCalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 1, 2.95)]
        [InlineData(2, 0, 2, 3.10)]
        [InlineData(0, 4, 0, 3.45)]
        [InlineData(2, 8, 1, 9.00)]
        public void CheckCalculateCalculateCostsCalculatesCorrectly(int buttersQty, int milksQty, int breadsQty, decimal finalCost)
        {
            //  Arrange
            IPromoRepository promoRepository = new PromoRepository();
            IProductRepository productRepository = new ProductRepository();
            List<IPromo> testPromosList = new List<IPromo>() { promoRepository.GetPromoOne(), promoRepository.GetPromoTwo() };
            List<IProduct> testProductsList = productRepository.GetProducts(buttersQty, milksQty, breadsQty);
            IGroceriesBasket basket = new GroceriesBasket();
            basket.AddProducts(testProductsList);
            ICostCalculator costCalculator = new CostCalculator(basket, testPromosList);

            //  Act
            costCalculator.CalculateCosts();

            //  Assert that all the involved Costs are as they should be
            Assert.Equal(testProductsList.Sum(product => product.Price), costCalculator.TotalCost);                                 //  Total Cost of the Items
            Assert.Equal(testPromosList.Sum(promo => promo.CalculateDeduction(testProductsList)), costCalculator.PromosDeductions); //  Total Deductions from the applied Promos
            Assert.Equal(finalCost, costCalculator.FinalCost);                                                                      //  Final Cost
        }
    }
}
