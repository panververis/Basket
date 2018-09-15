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
        public void CheckAddButterAddsAButter()
        {
            //  Arrange
            Mock<IPromoRepository> promoRepository = new Mock<IPromoRepository>();
            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            productRepository.Setup(x => x.GetButter()).Returns(new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Butter));
            GroceriesBasket basket = new GroceriesBasket(promoRepository.Object, productRepository.Object);

            //  Act
            basket.AddButter();

            //  Assert
            Assert.Equal(1, basket.ProductsList.Count(x => x.ProductType == ProductTypes.Butter));
        }

        [Fact]
        public void CheckAddMilkAddsAMilk()
        {
            //  Arrange
            Mock<IPromoRepository> promoRepository = new Mock<IPromoRepository>();
            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            productRepository.Setup(x => x.GetMilk()).Returns(new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Milk));
            GroceriesBasket basket = new GroceriesBasket(promoRepository.Object, productRepository.Object);

            //  Act
            basket.AddMilk();

            //  Assert
            Assert.Equal(1, basket.ProductsList.Count(x => x.ProductType == Common.Enums.ProductTypes.Milk));
        }

        [Fact]
        public void CheckAddBreadAddsABread()
        {
            //  Arrange
            Mock<IPromoRepository> promoRepository = new Mock<IPromoRepository>();
            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            productRepository.Setup(x => x.GetBread()).Returns(new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Bread));
            GroceriesBasket basket = new GroceriesBasket(promoRepository.Object, productRepository.Object);

            //  Act
            basket.AddBread();

            //  Assert
            Assert.Equal(1, basket.ProductsList.Count(x => x.ProductType == ProductTypes.Bread));
        }

        [Fact]
        public void CheckAddProductsAddsProducts()
        {
            //  Arrange
            Mock<IPromoRepository> promoRepository = new Mock<IPromoRepository>();
            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            productRepository.Setup(x => x.GetProducts(1, 1, 1)).Returns(new List<Product>() { new Product(It.IsAny<string>(), It.IsAny<decimal>(), ProductTypes.Bread) });
            GroceriesBasket basket = new GroceriesBasket(promoRepository.Object, productRepository.Object);

            //  Act
            basket.AddProducts(1, 1, 1);

            //  Assert
            Assert.NotEmpty(basket.ProductsList);
        }

        [Fact]
        public void CheckAddPromosAddsPromos()
        {
            //  Arrange
            Mock<IPromoRepository> promoRepository = new Mock<IPromoRepository>();
            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            promoRepository.Setup(x => x.GetPromoOne()).Returns(new Promo(It.IsAny<string>(), It.IsAny<ProductTypes>(), It.IsAny<int>(), It.IsAny<ProductTypes>(), It.IsAny<int>()));
            GroceriesBasket basket = new GroceriesBasket(promoRepository.Object, productRepository.Object);

            //  Act
            basket.AddPromos();

            //  Assert
            Assert.NotEmpty(basket.PromosList);
        }

        [Theory]
        [InlineData(1, 1, 1, 2.95)]
        [InlineData(2, 0, 2, 3.10)]
        [InlineData(0, 4, 0, 3.45)]
        [InlineData(2, 8, 1, 9.00)]
        public void CheckCalculateFinalCostCalculatesCorrectly(int buttersQty, int milksQty, int breadsQty, decimal finalCost)
        {
            //  Arrange
            PromoRepository promoRepository = new PromoRepository();
            ProductRepository productRepository = new ProductRepository();

            GroceriesBasket basket = new GroceriesBasket(promoRepository, productRepository);
            basket.AddProducts(buttersQty, milksQty, breadsQty);
            basket.AddPromos();

            //  Act
            basket.CalculateFinalCost();

            //  Assert
            Assert.Equal(finalCost, basket.FinalCost);
        }
    }
}
