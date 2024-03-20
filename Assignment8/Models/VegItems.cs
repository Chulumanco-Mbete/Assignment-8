using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class VegItems
    {
        [PrimaryKey, AutoIncrement] public int VegId { get; set; }
        
        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public double Price { get; set;}
        
        public int Quantity { get; set; }

        //[ForeignKey(typeof(User))] public int UserId { get; set; }

        //[ManyToOne] public User User { get; set; }
    }
}
