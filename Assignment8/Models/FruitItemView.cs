﻿using System.Collections.ObjectModel;
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
