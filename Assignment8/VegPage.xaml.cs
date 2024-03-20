using Assignment8.Models;
namespace Assignment8;
using System;

public partial class VegPage : ContentPage
{
    public VegPage()
	{
        InitializeComponent();
        this.BindingContext = new VegItemView(this.Navigation);
    }

    void ListView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Console.WriteLine("I got clicked");
    }
}