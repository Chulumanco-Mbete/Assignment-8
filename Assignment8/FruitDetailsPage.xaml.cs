using Assignment8.Models;
using Assignment8.Services;
using System;

namespace Assignment8;

public partial class FruitDetailsPage : ContentPage
{
    public FruitDetailsPage(FruitItemView item)
	{
        InitializeComponent();
        BindingContext = item;
    }
}