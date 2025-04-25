namespace Leap_App.Views;
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent(); // Ensure this is present
    }
    private void GoToHome(object sender, EventArgs e)
    {
        // Navigation logic here
        Shell.Current.GoToAsync("//HomePage");
    }
    private void GoToShop(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ShopPage");
    }
    private void GoToObjectives(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ObjectivePage");
    }

        private async void GoToLeaderboard(object sender, EventArgs e)
        {
            // Navigate to the LeaderboardPage
            await Navigation.PushAsync(new LeaderboardPage());
        }
    }
    private async void OnProfileIconClicked(object sender, EventArgs e)
    {
        // Check if the user is logged in
        bool isLoggedIn = Preferences.Get("IsLoggedIn", false);

        if (!isLoggedIn)
        {
            // Navigate to SignInPage
            await Shell.Current.GoToAsync("//SignInPage");
        }
        else
        {
            // Display user profile or account details
            await DisplayAlert("Profile", $"Logged in as: {Preferences.Get("Username", "Guest")}", "OK");
        }
    }
}