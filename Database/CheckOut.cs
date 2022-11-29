// using api.Interfaces;
// using api.Models;
// using MySql.Data.MySqlClient;

// namespace api.Database
// {
//     public class CheckOut : ICheckOut
//     {
//         //Save everything to a new table (purchaseorders)
//         public void SavePurchaseOrder() {
//             ConnectionString myConnection = new ConnectionString();
//             string cs = myConnection.cs;

//             MySqlConnection con = new MySqlConnection(cs);
//             con.Open();

//             string stm = @"INSERT INTO purchaseorders() VALUES (@name, @cost)";
            
//             MySqlCommand cmd = new MySqlCommand(stm, con);
//             cmd.Parameters.AddWithValue("@name", cart.ProductName);
//             cmd.Parameters.AddWithValue("@cost", cart.ProductPrice);

//             cmd.ExecuteNonQuery();
//             con.Close();
//         }

//         //"Remove" everything from the Cart table --> hard delete
//         public void RemoveFromShoppingCart(int ProductID) {
//             ConnectionString myConnection = new ConnectionString();
//             string cs = myConnection.cs;

//             MySqlConnection con = new MySqlConnection(cs);
//             con.Open();

//             string stm = @"DELETE from cart WHERE id = @id"; //DOUBLE CHECK

//             MySqlCommand cmd = new MySqlCommand(stm, con);

//             cmd.Parameters.AddWithValue("@id", ProductID);

//             cmd.Prepare();
//             cmd.ExecuteNonQuery();
//         }


//         //"Remove" everything from the Inventory --> just updating the availqty
//         public int UpdateQty(int ProductID, Inventory inventory) {
//             ConnectionString myConnection = new ConnectionString();
//             string cs = myConnection.cs;

//             MySqlConnection con = new MySqlConnection(cs);
//             con.Open();

//             //Have cartQty from cart affect the qty from product
//             string stm = @"UPDATE product SET qty -= cartQty WHERE id = @id"; //DOUBLE CHECK

//             MySqlCommand cmd = new MySqlCommand(stm, con);

//             cmd.Parameters.AddWithValue("@id", ProductID);

//             cmd.Prepare();
//             cmd.ExecuteNonQuery();
//         }
//     }
// }