using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment8.Models
{
    public class BakeryItemView
    {
        public ObservableCollection<BakeryItems> BakeryItems { get; set; }

        //public ObservableCollection<VegItems> CartProducts { get; set; }

        public BakeryItems SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        //public ICommand CartProductClick { get; set; }
        public BakeryItemView(INavigation navigation)
        {
            BakeryItems = new ObservableCollection<BakeryItems>
            {
                new BakeryItems
                {
                    Name = "White Bread",
                    Image = "",
                    Description = "",
                    Price = 15.99,
                    Quantity = 50
                },

                new BakeryItems
                {
                    Name = "Brown Bread",
                    Image = "",
                    Description = "",
                    Price = 17.99,
                    Quantity = 50
                },

                new BakeryItems
                {
                    Name = "Paninis",
                    Image = "",
                    Description = "",
                    Price = 12.99,
                    Quantity = 50
                },

                new BakeryItems
                {
                    Name = "Garlic Bread",
                    Image = "",
                    Description = "",
                    Price = 13.99,
                    Quantity = 50
                },
            };

            //CartProducts = new ObservableCollection<BakeryItems> { };

            ProductClick = new Command<BakeryItems>(executeProductClickCommand);

            //CartProductClick = new Command<BakeryItems>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(BakeryItems item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            await navigation.PushModalAsync(new BakeryDetails(this));
        }

        //async void executeCartProductClickCommand(BakeryItems item)
        //{
        //    this.CartProducts.Add(this.SelectedProduct);
        //    //await navigation.PushModalAsync(new CartPage(this));
        //}

    }
}
