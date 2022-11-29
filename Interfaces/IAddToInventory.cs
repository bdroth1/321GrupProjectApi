using api.Models;

namespace api.Interfaces
{
    public interface IAddToInventory
    {
        public void AddProduct(Inventory inventory);
    }
}