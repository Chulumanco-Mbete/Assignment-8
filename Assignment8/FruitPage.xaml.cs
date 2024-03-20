namespace Assignment8;
using Assignment8.Models;
using Assignment8.Services;
using System;

public partial class FruitPage : ContentPage
{

    public FruitPage()
	{
        InitializeComponent();
        this.BindingContext = new FruitItemView(this.Navigation);
    }

    void ListView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Console.WriteLine("I got clicked");
    }
}