using api.Models;

namespace api.Interfaces
{
    public interface IEditInventoryCount
    {
        public void EditQty(int ProductID, Inventory inventory);
    }
}