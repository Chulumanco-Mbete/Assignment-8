using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment8.Models
{
    public class ButcheryItemView
    {
        public ObservableCollection<ButcheryItems> ButcheryItems { get; set; }

        //public ObservableCollection<ButcheryItems> CartProducts { get; set; }

        public ButcheryItems SelectedProduct { get; set; }

        public ICommand ProductClick { get; set; }

        //public ICommand CartProductClick { get; set; }
        public ButcheryItemView(INavigation navigation)
        {
            ButcheryItems = new ObservableCollection<ButcheryItems>
            {
                new ButcheryItems
                {
                    Name = "Lamb",
                    Image = "",
                    Description = "",
                    Price = 119.99,
                    Quantity = 50
                },

                new ButcheryItems
                {
                    Name = "Pork",
                    Image = "",
                    Description = "",
                    Price = 89.99,
                    Quantity = 50
                },

                new ButcheryItems
                {
                    Name = "Chicken",
                    Image = "",
                    Description = "",
                    Price = 59.99,
                    Quantity = 50
                },

                new ButcheryItems
                {
                    Name = "Sausage",
                    Image = "",
                    Description = "",
                    Price = 49.99,
                    Quantity = 50
                },
            };

            //CartProducts = new ObservableCollection<ButcheryItems> { };

            ProductClick = new Command<ButcheryItems>(executeProductClickCommand);

            //CartProductClick = new Command<ButcheryItems>(executeCartProductClickCommand);

            this.navigation = navigation;
        }
        private INavigation navigation;

        async void executeProductClickCommand(ButcheryItems item)
        {
            Console.WriteLine("I'm clicking the product!");
            this.SelectedProduct = item;
            await navigation.PushModalAsync(new ButcheryDetails(this));
        }

        //async void executeCartProductClickCommand(ButcheryItems item)
        //{
        //    this.CartProducts.Add(this.SelectedProduct);
        //    //await navigation.PushModalAsync(new CartPage(this));
        //}

    }
}
