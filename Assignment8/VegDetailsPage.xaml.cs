using Assignment8.Models;

namespace Assignment8;

public partial class VegDetailsPage : ContentPage
{
    public VegDetailsPage(VegItemView vegItemView)
    {
        InitializeComponent();
        BindingContext = vegItemView;
    }
}