namespace Leap_App.Views;
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent(); // Ensure this is present
        StartFloatingAnimation();
        LoadUserProfile();
    }

    private void LoadUserProfile()
    {
        string username = Preferences.Get("Username", "Guest");
        UsernameLabel.Text = username;
    }
    private async void StartFloatingAnimation()
    {
        while (true)
        {
            // Move the flag up
            await FlagImage.TranslateTo(0, -10, 2500, Easing.Linear);
            // Move the flag down
            await FlagImage.TranslateTo(0, 0, 2500, Easing.Linear);
        }
    }
    private void GoToCampaign(object sender, EventArgs e)
    {
        // Navigation logic for Campaign Mode
        Shell.Current.GoToAsync("//CampaignPage");
    }
    private void GoToMiniGame(object sender, EventArgs e)
    {
        // Navigation logic for Mini Game Mode
        Shell.Current.GoToAsync("//MiniGamePage");
    }
    private void GoToHome(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//HomePage_Main");
    }
    private void GoToShop(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ShopPage");
    }
    private void GoToObjectives(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ObjectivePage");
    }

    private void GoToLeaderboard(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//LeaderboardPage");
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