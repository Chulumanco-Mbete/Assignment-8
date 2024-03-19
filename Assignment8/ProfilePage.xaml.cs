using Assignment8.Models;
using Assignment8.Services;

namespace Assignment8
{
    public partial class ProfilePage : ContentPage
    {
        private LocalDatabase _database;

        private User _currentUser;

        public User CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;

                OnPropertyChanged();
            }
        }

        public ProfilePage()
        {
            InitializeComponent();

            _database = new LocalDatabase();

            BindingContext = this;
        }

        private void ReloadButton_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            User user = _database.GetUserById(1);

            CurrentUser = user;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            _database.UpdateUser(CurrentUser);

            await DisplayAlert("Alert", "User has been saved.", "OK");
        }
    }

}
