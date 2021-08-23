namespace Project0.StoreApplication.Domain.Models
{
    public class Product
    {
        public string ProductName {get; set;}

        public override string ToString(){

            if (ProductName != null){
                return ProductName;
            }
            else {
                var noProductName = "N/A";
                return noProductName;
            }

            
        }
    }


}