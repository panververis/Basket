using Common.Enums;

namespace Common
{
    /// <summary>
    /// This static class serves the sole purpose of keeping some "shared" Test Information, 
    /// suitable for the purposes of this small project
    /// </summary>
    public static class CommonTestInfo
    {
        //  Rounding point
        public static int               RoundingPoints                  => 2;

        //  Initial Product Prices
        public static decimal           ButterPrice                     => 0.80m;
        public static decimal           MilkPrice                       => 1.15m;
        public static decimal           BreadPrice                      => 1.00m;


        //  Promos Properties   //

        //  Promo One
        public static string            PromoOneDescription             => "Buy 2 Butter and get a Bread at 50% off!! What an amazing offer!";
        public static int               PromoOneRequiredProductQty      => 2;
        public static int               PromoOneDiscountPercentage      => 50;
        public static ProductType      PromoOneRequiredProductType      => ProductType.Butter;
        public static ProductType      PromoOneApplicableProductType    => ProductType.Bread;
        //  Promo Two
        public static string            PromoTwoDescription             => "Buy 3 Milk and get the 4th milk for free!! Another amazing offer!";
        public static int               PromoTwoRequiredProductQty      => 4;
        public static int               PromoTwoDiscountPercentage      => 100;
        public static ProductType      PromoTwoRequiredProductType      => ProductType.Milk;
        public static ProductType      PromoTwoApplicableProductType    => ProductType.Milk;
    }
}
