using Basket.Domain.Classes.Concrete;

namespace Basket.Domain.Repositories.Interfaces
{
    public interface IPromoRepository
    {
        Promo GetPromoOne();
        Promo GetPromoTwo();
    }
}
