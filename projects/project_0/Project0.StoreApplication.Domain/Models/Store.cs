using System;

namespace Project0.StoreApplication.Domain.Models
{
    public class Store
    {
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