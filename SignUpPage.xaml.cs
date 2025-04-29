using Leap_App.Services;
namespace Leap_App.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            // Save account to the database
            var accountService = new AccountService();
            bool isCreated = await accountService.CreateAccountAsync(username, password);

            if (isCreated)
            {
                await DisplayAlert("Success", "Account created successfully!", "OK");
                await Shell.Current.GoToAsync("//SignInPage");
            }
            else
            {
                await DisplayAlert("Error", "Account creation failed. Username might already exist.", "OK");
            }
        }
    }
}