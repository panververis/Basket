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
            //Assert that the returned promo is the "predefined" first promo, 
            //suitable for the purposes of this project
        }

        [Fact]
        public void GetPromoTwoShouldReturnProperPromo()
        {
            //  Arrange
            //PromoRepository promoRepo = new promoRepo();

            //  Act
            //Promo promoTwo = promoRepo.GetPromoTwo();

            //  Assert
            //Assert that the returned promo is the "predefined" second promo, 
            //suitable for the purposes of this project
        }

        #endregion

        #region Helper Methods

        //  Here I will reference a common place in code that will define what are the "predefined" Promos,
        //  as required for the needs of this small project
        //  These will include  "IsTestPromoOne", "IsTestPromoTwo" for example

        #endregion
    }
}
