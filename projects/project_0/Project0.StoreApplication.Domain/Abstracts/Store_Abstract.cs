namespace Project0.StoreApplication.Domain.Abstracts
{
    public abstract class Store
    {
        public byte StoreId {get; set;}
        public string Name {get; set;}

        public override string ToString()
        {
            if (Name != null)
            {
                return Name;
            }

            else
            {
                var noName = "N/A";
                return noName;
            } 
        }
    }

}