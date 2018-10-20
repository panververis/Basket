using Common.Enums;

namespace Basket.Domain.Classes.Interfaces
{
    public interface IProduct
    {
        string      Name        { get; }
        decimal     Price       { get; }
        ProductType ProductType { get; }
    }
}
