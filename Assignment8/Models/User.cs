using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Assignment8.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement] public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }

        //[OneToMany(CascadeOperations = CascadeOperation.All)]
        //public List<ShoppingItem> ShoppingItems { get; set; }

        //public User()
        //{
        //    ShoppingItems = new List<ShoppingItem>();
        //}
    }
}
