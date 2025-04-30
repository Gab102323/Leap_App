using Leap_App.Services;

namespace Leap_App.Views
{
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
        }
        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            // Navigate to the SignUpPage
            await Shell.Current.GoToAsync("//SignUpPage");
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Please enter both username and password.", "OK");
                return;
            }

            // Validate credentials
            var accountService = new AccountService(); // Ensure AccountService is defined in Leap_App.Services
            bool isValid = await accountService.ValidateAccountAsync(username, password);

            if (isValid)
            {
                Preferences.Set("IsLoggedIn", true);
                Preferences.Set("Username", username);
                await DisplayAlert("Success", "Sign-in successful!", "OK");
                await Shell.Current.GoToAsync("MainHomePageRoute");


            }
            else
            {
                await DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }
    }
}