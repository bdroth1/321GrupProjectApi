using MySql.Data.MySqlClient;

namespace api
{
    public class ConnectionString
    {
        public string cs {get;}
        public ConnectionString() {
            string server = "o2olb7w3xv09alub.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "gl4e9cg009adwh4o";
            string port = "3306";
            string user = "cc54uouww5ydnh3m";
            string password = "my0vycbjh98t64zw";

            cs = $@"server={server}; user={user}; database={database}; port={port}; password={password}";

            MySqlConnection con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE IF NOT EXISTS product(id INT NOT NULL AUTO_INCREMENT, PRIMARY KEY(id), name VARCHAR(255), cost INT, qty INT, outofstock BOOLEAN)";
            
            MySqlCommand cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}