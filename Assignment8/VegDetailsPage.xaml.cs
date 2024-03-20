using Assignment8.Models;

namespace Assignment8;

public partial class VegDetailsPage : ContentPage
{
    private VegItems _currentVeg;

    public VegDetailsPage(VegItemView vegItemView)
    {
        InitializeComponent();
        BindingContext = vegItemView;
    }

    public VegItems CurrentVeg
    {
        get { return _currentVeg; }
        set
        {
            _currentVeg = value;
            OnPropertyChanged();
        }
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}