namespace Project0.StoreApplication.Domain.Models
{
    public class Product
    {
        public byte ProductId {get; set;}
        public string ProductName {get; set;}
        public double Price {get; set;}
        public int Quantity {get; set;}

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