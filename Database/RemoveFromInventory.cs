using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class RemoveFromInventory : IRemoveFromInventory
    {
        public void OutOfStockProduct(int ProductID) {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE product IF qty = 0 SET outofstock = 1 WHERE id = @id"; //DOUBLE CHECK

            MySqlCommand cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@id", ProductID);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}