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
                    VegName = "Tomatoes",
                    VegImage = "tomatoe.png",
                    VegDescription = "",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },

                new VegItems
                {
                    VegName = "Potatoes",
                    VegImage = "potatoe.png",
                    VegDescription = "",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },

                new VegItems
                {
                    VegName = "Broccoli",
                    VegImage = "broccoli.png",
                    VegDescription = "",
                    VegPrice = 29.99,
                    VegQuantity = 50
                },

                new VegItems
                {
                    VegName = "Cauliflower",
                    VegImage = "cauliflower.png",
                    VegDescription = "",
                    VegPrice = 29.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Cabbage",
                    VegImage = "cabbage.png",
                    VegDescription = "",
                    VegPrice = 28.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Carrots",
                    VegImage = "carrots.png",
                    VegDescription = "",
                    VegPrice = 23.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Cucumber",
                    VegImage = "cucumber.png",
                    VegDescription = "",
                    VegPrice = 14.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Lettuce",
                    VegImage = "lettuce.png",
                    VegDescription = "",
                    VegPrice = 24.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Onion",
                    VegImage = "onion.png",
                    VegDescription = "",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Red Onion",
                    VegImage = "red_onion.png",
                    VegDescription = "",
                    VegPrice = 34.99,
                    VegQuantity = 50
                },
                new VegItems
                {
                    VegName = "Spinach",
                    VegImage = "spinach.png",
                    VegDescription = "",
                    VegPrice = 39.99,
                    VegQuantity = 50
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
