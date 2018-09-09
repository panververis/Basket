using Basket.Domain;
using Common;
using System;
using System.Linq;
using Xunit;

namespace Basket.Tests.Repositories_Tests
{
    public class PromoRepositoryTests
    {
        #region Tests

        [Fact]
        public void GetPromoOneShouldReturnProperPromo()
        {
            //  Arrange
            //PromoRepository promoRepo = new promoRepo();

            //  Act
            //Promo promoOne = promoRepo.GetPromoOne();

            //  Assert
            //Assert.Equal(IsTestPromoOne(promoOne), true);
        }

        [Fact]
        public void GetPromoTwoShouldReturnProperPromo()
        {
            //  Arrange
            //PromoRepository promoRepo = new promoRepo();

            //  Act
            //Promo promoTwo = promoRepo.GetPromoTwo();

            //  Assert
            //Assert.Equal(IsTestPromoTwo(promoTwo), true);
        }

        #endregion

        #region Helper Methods

        private bool IsTestPromoOne(Promo promoOne)
        {
            return      promoOne.RequiredProductQty             == CommonTestInfo.PromoOneRequiredButterQty
                    &&  promoOne.RequiredProductType            == Common.Enums.ProductTypes.Butter
                    &&  promoOne.ApplicableDiscountPercentage   == CommonTestInfo.PromoOneDiscountPercentage
                    &&  promoOne.ApplicableProductType          == Common.Enums.ProductTypes.Bread;
        }


        private bool IsTestPromoTwo(Promo promoTwo)
        {
            return     promoTwo.RequiredProductQty              == CommonTestInfo.PromoTwoRequiredMilkQty
                    && promoTwo.RequiredProductType             == Common.Enums.ProductTypes.Milk
                    && promoTwo.ApplicableDiscountPercentage    == CommonTestInfo.PromoTwoDiscountPercentage
                    && promoTwo.ApplicableProductType           == Common.Enums.ProductTypes.Milk;
        }

        #endregion
    }
}
