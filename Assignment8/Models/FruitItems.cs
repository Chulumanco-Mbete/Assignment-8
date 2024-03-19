using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class FruitItems
    {
        [PrimaryKey, AutoIncrement] public int FruitId { get; set; }
        
        public string Name { get; set; }
        
        public double Price { get; set;}
        
        public int Quantity { get; set; }

        [ForeignKey(typeof(User))] public int UserId { get; set; }

        [ManyToOne] public User User { get; set; }
    }
}
