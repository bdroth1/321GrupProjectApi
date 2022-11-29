using api.Models;

namespace api.Interfaces
{
    public interface IRemoveFromInventory
    {
        public void OutOfStockProduct(int ProductID);
    }
}