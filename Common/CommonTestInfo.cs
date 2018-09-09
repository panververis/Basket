using System;

namespace Common
{
    /// <summary>
    /// This static class serves the sole purpose of keeping some "shared" Test Information, 
    /// suitable for the purposes of this small project
    /// </summary>
    public static class CommonTestInfo
    {
        //  Initial Product Prices
        public static decimal ButterPrice                   => 0.80m;
        public static decimal MilkPrice                     => 1.15m;
        public static decimal BreadPrice                    => 1.00m;

        //  Promo Properties
        public static int     PromoOneRequiredButterQty     => 2;
        public static int     PromoOneDiscountPercentage    => 50;
        public static int     PromoTwoRequiredMilkQty       => 4;
        public static int     PromoTwoDiscountPercentage    => 100;
    }
}
