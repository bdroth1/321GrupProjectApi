using api.Interfaces;
using api.Models;
using MySql.Data.MySqlClient;

namespace api.Database
{
    public class InventoryDataAccess : IGetAllProducts
    {
        public List<Inventory> GetAllProducts() {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                
                string stm = "SELECT * FROM product";
                MySqlCommand cmd = new MySqlCommand(stm, con);
                
                using MySqlDataReader rdr = cmd.ExecuteReader();
                
                List<Inventory> allInventory = new List<Inventory>();
                while(rdr.Read()) {
                    allInventory.Add(new Inventory(){ProductID = rdr.GetInt32(0), ProductName = rdr.GetString(1), ProductPrice = rdr.GetInt32(2), AvailableQty = rdr.GetInt32(3), OutOfStock = rdr.GetBoolean(4), ProductImage = rdr.GetString(5)});
                }
                return allInventory;
            }
        }

        public Inventory GetOneProduct(int id) {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                
                string stm = "SELECT * FROM product";
                MySqlCommand cmd = new MySqlCommand(stm, con);

                using MySqlDataReader rdr = cmd.ExecuteReader();
                
                Inventory oneProduct = new Inventory();
                if(id == oneProduct.ProductID) {
                    return oneProduct;
                }
                return null; //RETURN ERROR MESSAGE?
            }
        }
    }
}