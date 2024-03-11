using Assignment8.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System.Data.Common;

namespace Assignment8.Services
{
    public class LocalDatabase
    {
        private SQLiteConnection _dbConnection;

        public string GetDatabasePath()
        {
            string filename = "shoppingdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(pathToDb, filename);
        }

        public LocalDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());

            _dbConnection.CreateTable<User>();
            _dbConnection.CreateTable<ShoppingItems>();
            _dbConnection.CreateTable<ShoppingCart>();
        }

        public void SeedDatabase(User user)
        {
            _dbConnection.Insert(user);
        }

        /*public List<User> GetAllUsers()
        {
            return _dbConnection.Table<User>().ToList();
        }*/

        public void UpdateUser(User user)
        {
            _dbConnection.Update(user);
        }

        public User GetUserById(int id)
        {
            User user = _dbConnection.Table<User>().Where(x => x.UserId == id).FirstOrDefault();

            if (user != null)
                _dbConnection.GetChildren(user, true);

            return user;
        }
    }
}
