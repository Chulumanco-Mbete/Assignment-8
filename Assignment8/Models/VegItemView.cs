using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment8.Models
{
    public class VegItemView
    {
        public ObservableCollection<VegItems> VegItems { get; set; }

        //public ObservableCollection<VegItems> CartProducts { get; set; }

        public VegItems SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        //public ICommand CartProductClick { get; set; }
        public VegItemView(INavigation navigation) 
        {
            VegItems = new ObservableCollection<VegItems>
            {
                new VegItems
                {
                    Name = "Tomatoes",
                    Image = "tomatoe.png",
                    Description = "",
                    Price = 34.99,
                    Quantity = 50
                },

                new VegItems
                {
                    Name = "Potatoes",
                    Image = "potatoe.png",
                    Description = "",
                    Price = 34.99,
                    Quantity = 50
                },

                new VegItems
                {
                    Name = "Broccoli",
                    Image = "broccoli.png",
                    Description = "",
                    Price = 29.99,
                    Quantity = 50
                },

                new VegItems
                {
                    Name = "Cauliflower",
                    Image = "cauliflower.png",
                    Description = "",
                    Price = 29.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Cabbage",
                    Image = "cabbage.png",
                    Description = "",
                    Price = 28.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Carrots",
                    Image = "carrots.png",
                    Description = "",
                    Price = 23.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Cucumber",
                    Image = "banana.png",
                    Description = "",
                    Price = 14.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Lettuce",
                    Image = "lettuce.png",
                    Description = "",
                    Price = 24.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Onion",
                    Image = "onion.png",
                    Description = "",
                    Price = 34.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Red Onion",
                    Image = "red_onion.png",
                    Description = "",
                    Price = 34.99,
                    Quantity = 50
                },
                new VegItems
                {
                    Name = "Spinach",
                    Image = "spinach.png",
                    Description = "",
                    Price = 39.99,
                    Quantity = 50
                },
            };

            //CartProducts = new ObservableCollection<VegItems> { };

            ProductClick = new Command<VegItems>(executeProductClickCommand);

            //CartProductClick = new Command<VegItems>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(VegItems item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            await navigation.PushModalAsync(new VegDetailsPage(this));
        }

        //async void executeCartProductClickCommand(VegItems item)
        //{
        //    this.CartProducts.Add(this.SelectedProduct);
        //    //await navigation.PushModalAsync(new CartPage(this));
        //}

    }
}
