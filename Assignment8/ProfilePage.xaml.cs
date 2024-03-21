using Assignment8.Models;
using Assignment8.Services;

namespace Assignment8
{
    public partial class ProfilePage : ContentPage
    {
        private void ProfileBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
        public ProfilePage()
        {
            InitializeComponent();
        }
    }
}
