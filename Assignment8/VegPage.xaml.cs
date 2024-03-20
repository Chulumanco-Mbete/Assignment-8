using Assignment8.Models;

namespace Assignment8;

public partial class VegPage : ContentPage
{
    private VegItems _currentVeg;

    public VegItems CurrentVeg
    {
        get { return _currentVeg; }
        set
        {
            _currentVeg = value;

            OnPropertyChanged();
        }
    }

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