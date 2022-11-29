namespace api.Models
{
    public class Cart : Transaction
    {
        public int ProductID {get; set;}
        public string ProductName {get; set;}
        public int ProductPrice {get; set;}
        public int CartQty {get; set;}

        public Cart(){

        }
    }
}