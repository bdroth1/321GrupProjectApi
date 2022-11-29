using api.Models;
using api.Interfaces;
using MySql.Data.MySqlClient;


namespace api.Database
{
    public class EditInventoryCount : IEditInventoryCount
    {
        public void EditQty(int ProductID, Inventory inventory) {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            MySqlConnection con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE product SET qty = qty - 1 WHERE id = @id";
                
            MySqlCommand cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", ProductID);
            cmd.Parameters.AddWithValue("@qty", inventory.AvailableQty);     
                
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}