using Basket.Domain.Classes.Concrete;
using Basket.Domain.Repositories.Concrete;
using Common;
using Common.Enums;
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
            PromoRepository promoRepo = new PromoRepository();

            //  Act
            Promo promoOne = promoRepo.GetPromoOne();

            //  Assert
            Assert.True(IsTestPromoOne(promoOne));
        }

        [Fact]
        public void GetPromoTwoShouldReturnProperPromo()
        {
            //  Arrange
            PromoRepository promoRepo = new PromoRepository();

            //  Act
            Promo promoTwo = promoRepo.GetPromoTwo();

            //  Assert
            Assert.True(IsTestPromoTwo(promoTwo));
        }

        #endregion

        #region Helper Methods

        private bool IsTestPromoOne(Promo promoOne)
        {
            return      promoOne.RequiredProductQty             == CommonTestInfo.PromoOneRequiredButterQty
                    &&  promoOne.RequiredProductType            == ProductTypes.Butter
                    &&  promoOne.ApplicableDiscountPercentage   == CommonTestInfo.PromoOneDiscountPercentage
                    &&  promoOne.ApplicableProductType          == ProductTypes.Bread;
        }

        private bool IsTestPromoTwo(Promo promoTwo)
        {
            return     promoTwo.RequiredProductQty              == CommonTestInfo.PromoTwoRequiredMilkQty
                    && promoTwo.RequiredProductType             == ProductTypes.Milk
                    && promoTwo.ApplicableDiscountPercentage    == CommonTestInfo.PromoTwoDiscountPercentage
                    && promoTwo.ApplicableProductType           == ProductTypes.Milk;
        }

        #endregion
    }
}
