using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class BakeryItems
    {        
        [PrimaryKey, AutoIncrement] public int BakeryId { get; set; }
        
        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public double Price { get; set;}
        
        public int Quantity { get; set; }

        //[ForeignKey(typeof(User))] public int UserId { get; set; }

        //[ManyToOne] public User User { get; set; }
    }
}
