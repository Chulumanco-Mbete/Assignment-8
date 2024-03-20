using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class VegItems
    {
        public string VegName { get; set; }

        public string VegImage { get; set; }

        public string VegDescription { get; set; }

        public double VegPrice { get; set;}
        
        public int VegQuantity { get; set; }
    }
}
