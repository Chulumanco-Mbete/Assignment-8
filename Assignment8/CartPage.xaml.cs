using Assignment8.Models;
using Assignment8.Services;
using System.Collections.ObjectModel;

namespace Assignment8;

public partial class CartPage : ContentPage
{
    private LocalDatabase _database;

    private ObservableCollection<ShoppingCart> _basketitems;
    public ObservableCollection<ShoppingCart> BasketItems
    {
        get { return _basketitems; }
        set
        {
            _basketitems = value;
            OnPropertyChanged();
        }
    }
    public double TotalPrice => BasketItems.Sum(item => item.FruitPrice * item.FruitQantity);
    public CartPage()
    {
        InitializeComponent();
        //_viewModel = (CartViewModel)BindingContext;
        BindingContext = this;
        _database = new LocalDatabase();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        LoadData();
    }
    public void LoadData()
    {
        BasketItems = new ObservableCollection<ShoppingCart>(_database.GetCartItems());//See if additional code is needed here
    }
    private void OnRemoveClicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        var item = button.CommandParameter as ShoppingCart;
        if (item != null)//(sender is Button button && button.BindingContext is CartItem item)
        {
            BasketItems.Remove(item);
            _database.GetCartItems().Remove(item); //Check this
        }
    }
}