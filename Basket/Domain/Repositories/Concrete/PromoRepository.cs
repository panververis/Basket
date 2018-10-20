using Basket.Domain.Classes.Concrete;
using Basket.Domain.Repositories.Interfaces;
using Common;

namespace Basket.Domain.Repositories.Concrete
{
    public class PromoRepository : IPromoRepository
    {
        public Promo GetPromoOne()
        {
            return new Promo(
                CommonTestInfo.PromoOneDescription, 
                CommonTestInfo.PromoOneRequiredProductType,
                CommonTestInfo.PromoOneRequiredProductQty,
                CommonTestInfo.PromoOneApplicableProductType,
                CommonTestInfo.PromoOneDiscountPercentage);
        }

        public Promo GetPromoTwo()
        {
            return new Promo(
                CommonTestInfo.PromoTwoDescription,
                CommonTestInfo.PromoTwoRequiredProductType,
                CommonTestInfo.PromoTwoRequiredProductQty,
                CommonTestInfo.PromoTwoApplicableProductType,
                CommonTestInfo.PromoTwoDiscountPercentage);
        }
    }
}
