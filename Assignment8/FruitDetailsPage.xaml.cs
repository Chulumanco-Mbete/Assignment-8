using Assignment8.Models;
using Assignment8.Services;
using System;

namespace Assignment8;

public partial class FruitDetailsPage : ContentPage
{
    private FruitItems _currentFruit;

    public FruitItems CurrentFruit
    {
        get { return _currentFruit; }
        set
        {
            _currentFruit = value;

            OnPropertyChanged();
        }
    }

    public FruitDetailsPage(FruitItemView item)
	{
        InitializeComponent();
        BindingContext = item;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}