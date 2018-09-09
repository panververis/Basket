using Basket.Domain;
using Common;
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
