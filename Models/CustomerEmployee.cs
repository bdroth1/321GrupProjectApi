namespace api.Models
{
    public class CustomerEmployee : Transaction
    {
        public int ID {get; set;}
        public string? Username {get; set;}
        public string? Password {get; set;}
        public string? Email {get; set;}
        public bool Employee {get; set;}
        public bool Admin {get; set;}
        public CustomerEmployee() {
            
        }
    }
}