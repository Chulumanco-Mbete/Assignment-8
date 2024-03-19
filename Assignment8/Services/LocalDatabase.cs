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
            _dbConnection.CreateTable<BakeryItems>();
            _dbConnection.CreateTable<ButcheryItems>();
            _dbConnection.CreateTable<VegItems>();
            _dbConnection.CreateTable<FruitItems>();
            _dbConnection.CreateTable<ShoppingCart>();
        }

        public void SeedDatabase()
        {
            if (_dbConnection.Table<User>().Count() == 0)
            {
                User user = new User()
                {
                    Name = "",
                    Surname = "",
                    Email = "",
                    Bio = ""
                };
                _dbConnection.Insert(user);
            }

            if (_dbConnection.Table<FruitItems>().Count() == 0)
            {
                FruitItems fruit = new FruitItems()
                {
                    Name = "Green Apples",
                    Price = 18.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Yellow Apples",
                    Price = 18.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Red Apples",
                    Price = 18.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Blueberries",
                    Price = 21.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);

                fruit = new FruitItems()
                {
                    Name = "Raspberries",
                    Price = 22.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);

                fruit = new FruitItems()
                {
                    Name = "Blackberries",
                    Price = 25.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Watermelon",
                    Price = 99.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Sweet Melon",
                    Price = 59.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Dessert Peaches",
                    Price = 39.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Yellow Peaches",
                    Price = 49.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Strawberries",
                    Price = 45.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
                
                fruit = new FruitItems()
                {
                    Name = "Bananas",
                    Price = 49.99,
                    Quantity = 50
                };

                _dbConnection.Insert(fruit);
            }
            
            if (_dbConnection.Table<VegItems>().Count() == 0)
            {
                VegItems veg= new VegItems()
                {
                    Name = "Tomatoes",
                    Price = 34.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Potatoes",
                    Price = 34.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Broccoli",
                    Price = 29.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Cauliflower",
                    Price = 29.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);

                veg = new VegItems()
                {
                    Name = "Cabbage",
                    Price = 28.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);

                veg = new VegItems()
                {
                    Name = "Carrots",
                    Price = 23.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Cucumber",
                    Price = 14.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Lettuce",
                    Price = 24.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Onion",
                    Price = 34.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Red Onion",
                    Price = 34.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
                
                veg = new VegItems()
                {
                    Name = "Spinach",
                    Price = 39.99,
                    Quantity = 50
                };

                _dbConnection.Insert(veg);
            }

            if (_dbConnection.Table<ButcheryItems>().Count() == 0)
            {
                ButcheryItems butchery = new ButcheryItems()
                {
                    Name = "Lamb",
                    Price = 119.99,
                    Quantity = 50
                };

                _dbConnection.Insert(butchery);

                butchery = new ButcheryItems()
                {
                    Name = "Pork",
                    Price = 89.99,
                    Quantity = 50
                };

                _dbConnection.Insert(butchery);

                butchery = new ButcheryItems()
                {
                    Name = "Chicken",
                    Price = 59.99,
                    Quantity = 50
                };

                _dbConnection.Insert(butchery);

                butchery = new ButcheryItems()
                {
                    Name = "Sausage",
                    Price = 49.99,
                    Quantity = 50
                };
            }
            
            if (_dbConnection.Table<BakeryItems>().Count() == 0)
            {
                BakeryItems bakery = new BakeryItems()
                {
                    Name = "White Bread",
                    Price = 15.99,
                    Quantity = 50
                };

                _dbConnection.Insert(bakery);

                bakery = new BakeryItems()
                {
                    Name = "Brown Bread",
                    Price = 17.99,
                    Quantity = 50
                };

                _dbConnection.Insert(bakery);

                bakery = new BakeryItems()
                {
                    Name = "Paninis",
                    Price = 12.99,
                    Quantity = 50
                };

                _dbConnection.Insert(bakery);

                bakery = new BakeryItems()
                {
                    Name = "Garlic Bread",
                    Price = 13.99,
                    Quantity = 50
                };
            }
        }

        /*public List<User> GetAllUsers()
        {
            return _dbConnection.Table<User>().ToList();
        }*/

        public List<FruitItems> GetAllFruitItems()
        {
            var fruits = _dbConnection.Table<FruitItems>().ToList();
            return fruits;
        }
        
        public List<VegItems> GetAllVegItems()
        {
            var veg = _dbConnection.Table<VegItems>().ToList();
            return veg;
        }
        
        public List<ButcheryItems> GetAllButcheryItems()
        {
            var butchery = _dbConnection.Table<ButcheryItems>().ToList();
            return butchery;
        }
        
        public List<BakeryItems> GetAllBakeryItems()
        {
            var bakery = _dbConnection.Table<BakeryItems>().ToList();
            return bakery;
        }

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
