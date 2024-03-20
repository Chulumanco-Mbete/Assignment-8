using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class BakeryItems
    {
        public string BakeName { get; set; }

        public string BakeImage { get; set; }

        public string BakeDescription { get; set; }

        public double BakePrice { get; set;}
        
        public int BakeQuantity { get; set; }
    }
}
