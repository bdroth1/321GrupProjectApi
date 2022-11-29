namespace api.Models
{
    public class Inventory : Transaction
    {
        public int ProductID {get; set;}
        public string ProductName {get; set;}
        public int ProductPrice {get; set;}
        public int AvailableQty {get; set;}
        public bool OutOfStock {get; set;}
        public string ProductImage {get; set;}
        public Inventory() {

        }
    }
}