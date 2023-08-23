using NewApp.Models;

namespace NewApp.Services
{
    public class CartService : ICartService
    {
        public event Action? OnChange;
        public List<Product> cart = new();
        public double total;

        public double Total{
            get => total;
        }

        public IList<Product> Cart{
            get => cart;
        }
        public void AddProduct(Product product){
            cart.Add(product);
            OnChange?.Invoke();
            total += product.Price;

        }
        public void RemoveProduct(Product product){
            cart.Remove(product);
            OnChange?.Invoke();
            total -= product.Price;

        }
    }
}