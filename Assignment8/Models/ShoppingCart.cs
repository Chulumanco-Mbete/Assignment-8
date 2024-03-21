

using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class ShoppingCart
    {
        [PrimaryKey, AutoIncrement]
        public int CartItemId { get; set; }
        public int ItemQuantity { get; set; }
        public double CartPrice { get; set; }
        public string FruitName { get; set; }
        public int FruitQuantity { get; set; }


        [ForeignKey(typeof(FruitItems))]
        public int FruitId { get; set; }
        public int FruitQantity { get; internal set; }
        public int FruitPrice { get; internal set; }
        public string FruitImage { get; set; }
    }
}
