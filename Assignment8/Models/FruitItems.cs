using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class FruitItems
    {
        public string FruitName { get; set; }

        public string FruitImage { get; set; }

        public string FruitDescription { get; set; }
        
        public double FruitPrice { get; set;}
        
        public int FruitQuantity { get; set; }
    }
}
