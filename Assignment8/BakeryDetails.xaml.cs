using Assignment8.Models;

namespace Assignment8;

public partial class BakeryDetails : ContentPage
{
    private BakeryItemView bakeryItemView;

    public BakeryDetails()
	{
		InitializeComponent();
	}

    public BakeryDetails(BakeryItemView bakeryItemView)
    {
        this.bakeryItemView = bakeryItemView;
    }
}