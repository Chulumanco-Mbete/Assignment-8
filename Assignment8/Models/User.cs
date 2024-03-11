using SQLite;

namespace Assignment8.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement] public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
    }
}
