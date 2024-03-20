using Assignment8.Models;

namespace Assignment8;

public partial class ButcheryDetails : ContentPage
{
    private ButcheryItems _currentMeat;

    public ButcheryItems CurrentMeat
    {
        get { return _currentMeat; }
        set
        {
            _currentMeat = value;
            OnPropertyChanged();
        }
    }
    
    public ButcheryDetails(ButcheryItemView ItemView)
	{
		InitializeComponent();
        BindingContext = ItemView;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}