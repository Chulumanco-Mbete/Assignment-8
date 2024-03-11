using SQLite;

namespace Assignment8.Models
{
    public class ShoppingItems
    {
        [PrimaryKey, AutoIncrement] public int ItemId { get; set; }

        public string ItemDescription { get; set; }
    }
}
