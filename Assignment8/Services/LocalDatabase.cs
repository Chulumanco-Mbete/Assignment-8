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

            SeedDatabase();
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
                List<FruitItems> fruitItems = new List<FruitItems>()
                {
                    new FruitItems()
                {
                    FruitName = "Green Apples",
                    FruitImage = "green_apples.png",
                    FruitDescription = "1kg of Green Apples",
                    FruitPrice = 18.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Yellow Apples",
                    FruitImage = "yellow_apples.png",
                    FruitDescription = "1kg of Yellow Apples",
                    FruitPrice = 18.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Red Apples",
                    FruitImage = "red_apples.png",
                    FruitDescription = "1kg of Red Apples",
                    FruitPrice = 18.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Blueberries",
                    FruitImage = "blueberry.png",
                    FruitDescription = "300g of Blueberries",
                    FruitPrice = 21.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Raspberries",
                    FruitImage = "raspberry.png",
                    FruitDescription = "",
                    FruitPrice = 22.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Blackberries",
                    FruitImage = "blackberry.png",
                    FruitDescription = "",
                    FruitPrice = 25.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Watermelon",
                    FruitImage = "watermelon.png",
                    FruitDescription = "1 Full Watermelon",
                    FruitPrice = 99.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Sweet Melon",
                    FruitImage = "melon.png",
                    FruitDescription = "1 Full Sweet Melon",
                    FruitPrice = 59.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Dessert Peaches",
                    FruitImage = "dessert_peach.png",
                    FruitDescription = "1 box of Dessert Peachs",
                    FruitPrice = 39.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Yellow Peaches",
                    FruitImage = "peach.png",
                    FruitDescription = "1 box of Yellow Peaches",
                    FruitPrice = 49.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Strawberries",
                    FruitImage = "strawberry.png",
                    FruitDescription = "500g of Strawberries",
                    FruitPrice = 45.99,
                    FruitQuantity = 50
                },

                new FruitItems()
                {
                    FruitName = "Bananas",
                    FruitImage = "banana.png",
                    FruitDescription = "1 box of Bananas",
                    FruitPrice = 49.99,
                    FruitQuantity = 50
                }
                };

                _dbConnection.InsertAll(fruitItems);
            }

            if (_dbConnection.Table<VegItems>().Count() == 0)
            {
                List<VegItems> vegItems = new List<VegItems>()
                {
                    new VegItems
                {
                    VegName = "Tomatoes",
                    VegImage = "tomatoe.png",
                    VegDescription = "1kg of Tomatoes",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },

                new VegItems
                {
                    VegName = "Potatoes",
                    VegImage = "potatoe.png",
                    VegDescription = "1kg of Potatoes",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },

                new VegItems
                {
                    VegName = "Broccoli",
                    VegImage = "broccoli.png",
                    VegDescription = "Only broccoli pack",
                    VegPrice = 29.99,
                    VegQuantity = 50
                },

                new VegItems
                {
                    VegName = "Cauliflower",
                    VegImage = "cauliflower.png",
                    VegDescription = "Only cauliflower pack",
                    VegPrice = 29.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Cabbage",
                    VegImage = "cabbage.png",
                    VegDescription = "1 Full Cabbage",
                    VegPrice = 28.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Carrots",
                    VegImage = "carrots.png",
                    VegDescription = "1kg of Carrotss",
                    VegPrice = 23.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Cucumber",
                    VegImage = "cucumber.png",
                    VegDescription = "1 Full English Cucumber",
                    VegPrice = 14.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Lettuce",
                    VegImage = "lettuce.png",
                    VegDescription = "500g pack of lettuce",
                    VegPrice = 24.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Onion",
                    VegImage = "onion.png",
                    VegDescription = "1kg of Onions",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Red Onion",
                    VegImage = "red_onion.png",
                    VegDescription = "1kg of Red Onions",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Spinach",
                    VegImage = "spinach.png",
                    VegDescription = "750g pack of ready to cook spinach",
                    VegPrice = 39.99,
                    VegQuantity = 50
                }
            };
                _dbConnection.InsertAll(vegItems);
            }

            if (_dbConnection.Table<ButcheryItems>().Count() == 0)
            {
                List<ButcheryItems> meatItems = new List<ButcheryItems>()
                {
                    new ButcheryItems
                {
                    MeatName = "Lamb",
                    MeatImage = "lamb.png",
                    MeatDescription = "",
                    MeatPrice = 119.99,
                    MeatQuantity = 50
                },

                new ButcheryItems
                {
                    MeatName = "Pork",
                    MeatImage = "pork.png",
                    MeatDescription = "",
                    MeatPrice = 89.99,
                    MeatQuantity = 50
                },

                new ButcheryItems
                {
                    MeatName = "Chicken",
                    MeatImage = "chicken.png",
                    MeatDescription = "",
                    MeatPrice = 59.99,
                    MeatQuantity = 50
                },

                new ButcheryItems
                {
                    MeatName = "Sausage",
                    MeatImage = "sausage.png",
                    MeatDescription = "",
                    MeatPrice = 49.99,
                    MeatQuantity = 50
                }
                };
                    _dbConnection.InsertAll(meatItems);
            }

            if (_dbConnection.Table<BakeryItems>().Count() == 0)
            {
                List<BakeryItems> bakeItems = new List<BakeryItems>()
                {
                    new BakeryItems
                {
                    BakeName = "White Bread",
                    BakeImage = "white_bread.png",
                    BakeDescription = "",
                    BakePrice = 15.99,
                    BakeQuantity = 50
                },

                new BakeryItems
                {
                    BakeName = "Brown Bread",
                    BakeImage = "brown_bread.png",
                    BakeDescription = "",
                    BakePrice = 17.99,
                    BakeQuantity = 50
                },

                new BakeryItems
                {
                    BakeName = "Paninis",
                    BakeImage = "panini.png",
                    BakeDescription = "",
                    BakePrice = 12.99,
                    BakeQuantity = 50
                },

                new BakeryItems
                {
                    BakeName = "Garlic Bread",
                    BakeImage = "garlic_bread.png",
                    BakeDescription = "",
                    BakePrice = 13.99,
                    BakeQuantity = 50
                }
                };
                _dbConnection.InsertAll(bakeItems);
            }
        }

        public List<User> GetAllUsers()
        {
            return _dbConnection.Table<User>().ToList();
        }

        public List<FruitItems> GetAllFruitItems()
        {
            return _dbConnection.Table<FruitItems>().ToList();
        }

        public List<VegItems> GetAllVegItems()
        {
            return _dbConnection.Table<VegItems>().ToList();
        }

        public List<ButcheryItems> GetAllButcheryItems()
        {
            return _dbConnection.Table<ButcheryItems>().ToList();
        }

        public List<BakeryItems> GetAllBakeryItems()
        {
            return _dbConnection.Table<BakeryItems>().ToList();
        }

        public List<ShoppingCart> GetCartItems()
        {
            return _dbConnection.Table<ShoppingCart>().ToList();
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

        public FruitItems GetItemById(int id)
        {
            FruitItems fruitItems = _dbConnection.Table<FruitItems>().Where(x => x.FruitId == id).FirstOrDefault();

            if (fruitItems != null)
                _dbConnection.GetChildren(fruitItems, true);

            return fruitItems;
        }
        public void AddToDataBase(ShoppingCart cartItem) //Add Item from from db to cart
        {
            _dbConnection.Insert(cartItem);
        }
        public void DeleteFromDataBase(ShoppingCart cartItem) //Remove Item from from cart to db
        {
            _dbConnection.Delete(cartItem);
        }
    }
}
