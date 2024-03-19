namespace Assignment8;
using Assignment8.Models;
using Assignment8.Services;


public partial class FruitPage : ContentPage
{
    private LocalDatabase _database;
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

    public FruitPage()
	{
        InitializeComponent();

        _database = new LocalDatabase();

        BindingContext = this;
    }

    //public List<>
}