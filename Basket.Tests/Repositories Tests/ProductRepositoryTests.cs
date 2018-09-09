using Basket.Domain;
using Basket.Domain.Repositories.Concrete;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Basket.Tests.Repositories_Tests
{
    public class ProductRepositoryTests
    {
        #region Tests

        [Fact]
        public void GetButterShouldReturnPredefinedButterProduct() {
            //  Arrange
            ProductRepository prodRepo = new ProductRepository();

            //  Act
            Product butter = prodRepo.GetButter();

            //  Assert
            Assert.True(IsTestButter(butter));
        }

        [Fact]
        public void GetMilkShouldReturnPredefinedMilkProduct() {
            //  Arrange
            ProductRepository prodRepo = new ProductRepository();

            //  Act
            Product milk = prodRepo.GetMilk();

            //  Assert
            Assert.True(IsTestMilk(milk));
        }

        [Fact]
        public void GetBreadShouldReturnPredefinedBreadProduct() {
            //  Arrange
            ProductRepository prodRepo = new ProductRepository();

            //  Act
            Product bread = prodRepo.GetBread();

            //  Assert
            Assert.True(IsTestBread(bread));
        }

        [Theory]
        [InlineData(null, null, null)]
        [InlineData(1, 2, 3)]
        [InlineData(10, 20, 30)]
        [InlineData(5, 6, 8)]
        [InlineData(14, 9, 100)]
        public void GetProductsWithCorrectNumberOfProducts(int? buttersQty, int? milksQty, int? breadQty) {
            //  Arrange
            ProductRepository prodRepo = new ProductRepository();

            //  Act
            List<Product> products = prodRepo.GetProducts(buttersQty, milksQty, breadQty);

            //  Assert
            Assert.Equal(buttersQty.GetValueOrDefault(1), products.Count(x => x.ProductType == Common.Enums.ProductTypes.Butter));
            Assert.Equal(milksQty.GetValueOrDefault(1), products.Count(x => x.ProductType == Common.Enums.ProductTypes.Milk));
            Assert.Equal(breadQty.GetValueOrDefault(1), products.Count(x => x.ProductType == Common.Enums.ProductTypes.Bread));
        }

        [Theory]
        [InlineData(-6, -100, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 0, -4)]
        [InlineData(0, -14, -4)]
        public void GetProductsWithZeroOrNegativeArgumentsShouldThrowException(int? buttersQty, int? milksQty, int? breadQty)
        {
            //  Arrange
            ProductRepository prodRepo = new ProductRepository();

            //  Act / Assert
            Assert.Throws<Exception>(() => prodRepo.GetProducts(buttersQty, milksQty, breadQty));
        }

        #endregion

        #region Helper Methods

        private bool IsTestButter(Product butter)
        {
            return      butter.ProductType == Common.Enums.ProductTypes.Butter 
                    &&  butter.Price == CommonTestInfo.ButterPrice;
        }

        private bool IsTestMilk(Product milk)
        {
            return milk.ProductType == Common.Enums.ProductTypes.Milk
                    && milk.Price == CommonTestInfo.MilkPrice;
        }

        private bool IsTestBread(Product bread)
        {
            return bread.ProductType == Common.Enums.ProductTypes.Bread
                    && bread.Price == CommonTestInfo.BreadPrice;
        }

        #endregion
    }
}
