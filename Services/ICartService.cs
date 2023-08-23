using NewApp.Models;

namespace NewApp.Services
{
    public interface ICartService
    {
        event Action OnChange;
        IList<Product> Cart { get; }
        double Total { get; }
        void AddProduct(Product product);
        void RemoveProduct(Product product);


    }
}