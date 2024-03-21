using Assignment8.Models;
using Assignment8.Services;
using CloudKit;
using System;

namespace Assignment8;

public partial class FruitDetailsPage : ContentPage
{
    private LocalDatabase _database;

    public FruitDetailsPage(FruitItemView item)
	{
        InitializeComponent();
        BindingContext = item;
    }

    private List<ShoppingCart> Basket = new List<ShoppingCart>();

    private async void CartItemclick(object sender, EventArgs e)
    {
        Button button = sender as Button;
        var item = button.CommandParameter as FruitItems;
        //Navigation.PushAsync(new FruitDetailsPage());
        //LoadItem();
        if (item != null)//(sender is Button button && button.BindingContext is FruitItems item)
        {
            ShoppingCart AlreadyAdded = Basket.FirstOrDefault(i => i.FruitId == item.FruitId);
            if (AlreadyAdded != null)
            {
                AlreadyAdded.ItemQuantity++;
                AlreadyAdded.CartPrice += item.FruitPrice;
            }
            else
            {
                ShoppingCart cartItem = new ShoppingCart()
                {
                    CartItemId = item.FruitId,
                    FruitName = item.FruitName,
                    ItemQuantity = 1,
                    CartPrice = item.FruitPrice,
                    FruitImage = item.FruitImage,

                };
                Basket.Add(cartItem);
                _database.AddToDataBase(cartItem);
                await DisplayAlert("Notice", "Item Added To Cart", "Great");
            }
        }
    }

}