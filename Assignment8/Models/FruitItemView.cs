using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment8.Models
{
    public class FruitItemView
    {
        public ObservableCollection<FruitItems> FruitItems { get; set; }

        //public ObservableCollection<FruitItems> CartProducts { get; set; }

        public FruitItems SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        //public ICommand CartProductClick { get; set; }
        public FruitItemView(INavigation navigation) 
        {
            FruitItems = new ObservableCollection<FruitItems>
            {
                new FruitItems
                {
                    Name = "Green Apples",
                    Image = "green_apples.png",
                    Description = "",
                    Price = 18.99,
                    Quantity = 50
                },

                new FruitItems
                {
                    Name = "Yellow Apples",
                    Image = "yellow_apples.png",
                    Description = "",
                    Price = 18.99,
                    Quantity = 50
                },

                new FruitItems
                {
                   Name = "Red Apples",
                    Image = "red_apples.png",
                    Description = "",
                    Price = 18.99,
                    Quantity = 50
                },

                new FruitItems
                {
                    Name = "Blueberries",
                    Image = "blueberry.png",
                    Description = "",
                    Price = 21.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Raspberries",
                    Image = "raspberry.png",
                    Description = "",
                    Price = 22.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Blackberries",
                    Image = "blackberry.png",
                    Description = "",
                    Price = 25.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Watermelon",
                    Image = "watermelon.png",
                    Description = "",
                    Price = 99.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Sweet Melon",
                    Image = "melon.png",
                    Description = "",
                    Price = 59.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Dessert Peaches",
                    Image = "dessert_peach.png",
                    Description = "",
                    Price = 39.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Yellow Peaches",
                    Image = "peach.png",
                    Description = "",
                    Price = 49.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Strawberries",
                    Image = "strawberry.png",
                    Description = "",
                    Price = 45.99,
                    Quantity = 50
                },
                new FruitItems
                {
                    Name = "Bananas",
                    Image = "banana.png",
                    Description = "",
                    Price = 49.99,
                    Quantity = 50
                },
            };

            //CartProducts = new ObservableCollection<FruitItems> { };

            ProductClick = new Command<FruitItems>(executeProductClickCommand);

            //CartProductClick = new Command<FruitItems>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(FruitItems item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            await navigation.PushModalAsync(new FruitDetailsPage(this));
        }

        //async void executeCartProductClickCommand(FruitItems item)
        //{
        //    this.CartProducts.Add(this.SelectedProduct);
        //    //await navigation.PushModalAsync(new CartPage(this));
        //}

    }
}
