using api.Models;

namespace api.Interfaces
{
    public interface IGetAllProducts
    {
        List<Inventory> GetAllProducts();
        public Inventory GetOneProduct(int id);

    }
}