using System.Collections.Generic;

namespace Basket.Domain.Classes.Interfaces
{
    public interface ICostCalculator
    {
        decimal             TotalCost           { get; }
        decimal             PromosDeductions    { get; }
        decimal             FinalCost           { get; }
        List<IPromo>        PromosList          { get; }
        IGroceriesBasket    Basket              { get; }
        void                CalculateCosts();
    }
}
