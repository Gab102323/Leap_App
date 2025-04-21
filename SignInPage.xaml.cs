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
            // Validate user credentials (e.g., check SQLite or backend)
            // Navigate to HomePage if successful
            await Navigation.PushAsync(new HomePage());
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            // Navigate to SignUpPage
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}