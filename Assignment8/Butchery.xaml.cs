using Assignment8.Models;
using System;

namespace Assignment8;
public partial class Butchery : ContentPage
{
    public Butchery()
    {
        InitializeComponent();
        this.BindingContext = new ButcheryItemView(this.Navigation);
    }

    void ListView_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Console.WriteLine("I got clicked");
    }
}