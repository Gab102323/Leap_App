using Microsoft.Maui.Controls;

namespace Leap_App.Views
{

    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            string savedUsername = Preferences.Get("Username", string.Empty);
            string savedPassword = Preferences.Get("Password", string.Empty);

            if (UsernameEntry.Text == savedUsername && PasswordEntry.Text == savedPassword)
            {
                Preferences.Set("IsLoggedIn", true); // Save login state

                await DisplayAlert("Welcome", $"Welcome back, {savedUsername}!", "OK");

                // Navigate to HomePage
                await Shell.Current.GoToAsync("//HomePage_Main");
            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
        {
        }
    }
}