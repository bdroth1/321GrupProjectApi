using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class AddToInventory : IAddToInventory
    {
        public void AddProduct(Inventory inventory) {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO product(name, cost) VALUES (@name, @cost)";
            
            MySqlCommand cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@name", inventory.ProductName);
            cmd.Parameters.AddWithValue("@cost", inventory.ProductPrice);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}