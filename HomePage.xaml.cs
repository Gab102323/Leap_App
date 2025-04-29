using Leap_App.Services;
namespace Leap_App.Views;
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent(); // Ensure this is present
    }
    private async void OnProfileIconClicked(object sender, EventArgs e)
    {
        string username = Preferences.Get("Username", "Guest");
        var accountService = new AccountService();
        var progress = await accountService.GetProgressAsync(username);

        await DisplayAlert("Profile", $"Username: {username}\nProgress: {progress}%", "OK");
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
    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        // Navigate to the SettingsPage
        await Shell.Current.GoToAsync("//SettingsPage");
    }

    }