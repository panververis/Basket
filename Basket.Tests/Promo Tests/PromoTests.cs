using Basket.Domain.Classes.Concrete;
using Common;
using Common.Enums;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Basket.Tests.Promo_Tests
{
    /// <summary>
    /// Unit Test class, tests the two Test Promos separately for their Deduction-calculating functionality accuracy
    /// </summary>
    public class PromoTests
    {
        [Fact]
        public void CheckFirstPromoCalculateDeductionCalculatesCorrectDeduction()
        {
            //  Arrange
            Promo firstPromo = new Promo(
                CommonTestInfo.PromoOneDescription,
                CommonTestInfo.PromoOneRequiredProductType, 
                CommonTestInfo.PromoOneRequiredProductQty,
                CommonTestInfo.PromoOneApplicableProductType, 
                CommonTestInfo.PromoOneDiscountPercentage);

            List<Product> firstTestProductsList = new List<Product>() {
                new Product("bread",    CommonTestInfo.BreadPrice,  ProductType.Bread),
                new Product("butter",   CommonTestInfo.ButterPrice, ProductType.Butter),
                new Product("milk",     CommonTestInfo.ButterPrice, ProductType.Butter)
            };

            //  Act
            firstPromo.CalculateDeduction(firstTestProductsList);

            //  Assert
            Assert.Equal((Math.Round(CommonTestInfo.BreadPrice * firstPromo.ApplicableDiscountPercentage / 100, CommonTestInfo.RoundingPoints)), firstPromo.Deduction);
        }

        [Fact]
        public void CheckSecondPromoCalculateDeductionCalculatesCorrectDeduction()
        {
            //  Arrange
            Promo secondPromo = new Promo(
                CommonTestInfo.PromoTwoDescription,
                CommonTestInfo.PromoTwoRequiredProductType,
                CommonTestInfo.PromoTwoRequiredProductQty,
                CommonTestInfo.PromoTwoApplicableProductType,
                CommonTestInfo.PromoTwoDiscountPercentage);

            List<Product> secondTestProductsList = new List<Product>() {
                new Product("milk", CommonTestInfo.MilkPrice, ProductType.Milk),
                new Product("milk", CommonTestInfo.MilkPrice, ProductType.Milk),
                new Product("milk", CommonTestInfo.MilkPrice, ProductType.Milk),
                new Product("milk", CommonTestInfo.MilkPrice, ProductType.Milk)
            };

            //  Act
            secondPromo.CalculateDeduction(secondTestProductsList);

            //  Assert
            Assert.Equal((Math.Round(CommonTestInfo.MilkPrice * secondPromo.ApplicableDiscountPercentage / 100, CommonTestInfo.RoundingPoints)), secondPromo.Deduction);
        }
    }
}
