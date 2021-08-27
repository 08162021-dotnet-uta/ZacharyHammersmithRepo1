namespace Project0.StoreApplication.Domain.Models
{
    public class Customer
    {
        public byte CustomerId {get; set;}
        public string CustomerName {get; set;}
    

        public override string ToString()
        {

            if (CustomerName != null){
                return CustomerName;
            }
            else {
                var noCustomerName = "N/A";
                return noCustomerName;
            }
        }
    }
}