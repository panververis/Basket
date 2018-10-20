using Basket.Domain.Classes.Concrete;
using Basket.Domain.Classes.Interfaces;
using Common.Enums;
using Moq;
using System.Collections.Generic;
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
            basket.AddProduct(new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductType.Bread));

            //  Assert
            Assert.NotEmpty(basket.ProductsList);
        }

        [Fact]
        public void CheckAddProductsAddsProducts() {
            //  Arrange
            GroceriesBasket basket = new GroceriesBasket();

            //  Act
            basket.AddProducts(new List<IProduct>() {
                new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductType.Bread),
                new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductType.Butter)});

            //  Assert
            Assert.Equal(2, basket.ProductsList.Count);
        }
    }
}
