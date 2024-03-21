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
