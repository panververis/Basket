using Basket.Domain;
using Basket.Domain.Classes;
using Basket.Domain.Repositories.Concrete;
using Basket.Domain.Repositories.Interfaces;
using Common.Enums;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Basket.Tests.Basket_Tests
{
    public class BasketTests
    {
        [Fact]
        public void CheckAddProductAddsProduct() {
            //  Arrange
            GroceriesBasket basket = new GroceriesBasket();

            //  Act
            basket.AddProduct(new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Bread));

            //  Assert
            Assert.NotEmpty(basket.ProductsList);
        }

        [Fact]
        public void CheckAddProductsAddsProducts() {
            //  Arrange
            GroceriesBasket basket = new GroceriesBasket();

            //  Act
            basket.AddProducts(new List<Product>() {    new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Bread),
                                                        new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Butter)});

            //  Assert
            Assert.Equal(2, basket.ProductsList.Count);
        }

        [Fact]
        public void CheckAddPromoAddsPromo() {
            //  Arrange
            GroceriesBasket basket = new GroceriesBasket();

            //  Act
            basket.AddPromo(new Promo(It.IsAny<string>(), It.IsAny<ProductTypes>(), It.IsAny<int>(), It.IsAny<ProductTypes>(), It.IsAny<int>()));

            //  Assert
            Assert.NotEmpty(basket.PromosList);
        }

        [Fact]
        public void CheckAddPromosAddsPromos()
        {
            //  Arrange
            GroceriesBasket basket = new GroceriesBasket();

            //  Act
            basket.AddPromos(new List<Promo>(){ new Promo(It.IsAny<string>(), It.IsAny<ProductTypes>(), It.IsAny<int>(), It.IsAny<ProductTypes>(), It.IsAny<int>()),
                                                new Promo(It.IsAny<string>(), It.IsAny<ProductTypes>(), It.IsAny<int>(), It.IsAny<ProductTypes>(), It.IsAny<int>())});

            //  Assert
            Assert.Equal(2, basket.PromosList.Count);
        }

        //[Theory]
        //[InlineData(1, 1, 1, 2.95)]
        //[InlineData(2, 0, 2, 3.10)]
        //[InlineData(0, 4, 0, 3.45)]
        //[InlineData(2, 8, 1, 9.00)]
        //public void CheckCalculateFinalCostCalculatesCorrectly(int buttersQty, int milksQty, int breadsQty, decimal finalCost)
        //{
        //    //  Arrange
        //    PromoRepository promoRepository = new PromoRepository();
        //    ProductRepository productRepository = new ProductRepository();

        //    GroceriesBasket basket = new GroceriesBasket(promoRepository, productRepository);
        //    basket.AddProducts(buttersQty, milksQty, breadsQty);
        //    basket.AddPromos();

        //    //  Act
        //    basket.CalculateFinalCost();

        //    //  Assert
        //    Assert.Equal(finalCost, basket.FinalCost);
        //}
    }
}
