using Basket.Domain.Repositories.Interfaces;
using System;

namespace Basket.Domain.Repositories.Concrete
{
    public class PromoRepository : IPromoRepository
    {
        public Promo GetPromoOne()
        {
            return new Promo("Buy 2 Butter and get a Bread at 50% off!! What an amazing offer!", Common.Enums.ProductTypes.Butter, 2, Common.Enums.ProductTypes.Bread, 50);
        }

        public Promo GetPromoTwo()
        {
            return new Promo("Buy 3 Milk and get the 4th milk for free!! Another amazing offer!", Common.Enums.ProductTypes.Milk, 4, Common.Enums.ProductTypes.Milk, 100);
        }
    }
}
