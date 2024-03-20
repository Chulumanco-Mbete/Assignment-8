using Assignment8.Models;
namespace Assignment8;
using System;

public partial class Bakery : ContentPage
{
    public Bakery()
    {
        InitializeComponent();
        this.BindingContext = new BakeryItemView(this.Navigation);
    }

    void ListView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Console.WriteLine("I got clicked");
    }
}