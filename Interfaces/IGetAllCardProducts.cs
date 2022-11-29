using api.Models;

namespace api.Interfaces
{
    public interface IGetAllCardProducts
    {
        List<Cart> GetAllCartProducts();
        public Cart GetOneCartProduct(int id);
    }
}