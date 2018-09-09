using System;
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
            //ProductRepository prodRepo = new prodRepo();

            //  Act
            //Product butter = prodRepo.GetButter();

            //  Assert
            //Assert.Equal(IsTestButter(butter), true);
        }

        [Fact]
        public void GetMilkShouldReturnPredefinedMilkProduct() {
            //  Arrange
            //ProductRepository prodRepo = new prodRepo();

            //  Act
            //Product milk = prodRepo.GetMilk();

            //  Assert
            //Assert.Equal(IsTestMilk(milk), true);
        }

        [Fact]
        public void GetBreadShouldReturnPredefinedBreadProduct() {
            //  Arrange
            //ProductRepository prodRepo = new prodRepo();

            //  Act
            //Product bread = prodRepo.GetBread();

            //  Assert
            ////Assert.Equal(IsTestBread(bread), true);
        }

        [Theory]
        [InlineData(null, null, null)]
        public void GetProductsWithCorrectNumberOfProducts(int? buttersQty, int? milksQty, int? breadQty) {
            //  Arrange
            //ProductRepository prodRepo = new prodRepo();

            //  Act
            //IEnumerable products = prodRepo.GetProducts();

            //  Assert
            //Assert that the returned IEnumerable of Products holds the requested quantity of products of each kind
        }

        #endregion

        #region Helper Methods

        //  Here I will reference a common place in code that will define what are the "predefined" Products,
        //  as required for the needs of this small project
        //  These will include  "IsTestButter", "IsTestMilk", "IsTestBread" for example


        #endregion
    }
}
