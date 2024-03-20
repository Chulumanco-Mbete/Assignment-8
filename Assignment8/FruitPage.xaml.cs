namespace Assignment8;
using Assignment8.Models;
using Assignment8.Services;


public partial class FruitPage : ContentPage
{
    private FruitItems _currentFruit;

    public FruitItems CurrentFruit
    {
        get { return _currentFruit; }
        set {
            _currentFruit = value;

            OnPropertyChanged();
        }
    }

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