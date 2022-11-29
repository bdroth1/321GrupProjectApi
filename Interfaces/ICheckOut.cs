using api.Models;

namespace api.Interfaces
{
    public interface ICheckOut
    {
        public int UpdateQty(int ProductID, Inventory inventory); //Updating inventory
    }
}