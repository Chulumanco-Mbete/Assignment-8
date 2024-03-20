using Assignment8.Models;
namespace Assignment8;
using System;

public partial class BakeryDetails : ContentPage
{
    public BakeryDetails(BakeryItemView Item)
    {
        InitializeComponent();
        BindingContext = Item;
    }
}