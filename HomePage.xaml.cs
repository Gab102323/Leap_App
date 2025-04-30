using Leap_App.Services;

namespace Leap_App.Views;
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void GoToHome(object sender, EventArgs e)
    {
        // Navigate to the HomePage
        await Shell.Current.GoToAsync("//MainHomePage");
    }

    private async void GoToShop(object sender, EventArgs e)
    {
        // Navigate to the ShopPage
        await Shell.Current.GoToAsync("//ShopPage");
    }

    private async void GoToObjectives(object sender, EventArgs e)
    {
        // Navigate to the ObjectivePage
        await Shell.Current.GoToAsync("//ObjectivePage");
    }

    private async void GoToLeaderboard(object sender, EventArgs e)
    {
        // Navigate to the LeaderboardPage
        await Shell.Current.GoToAsync("//LeaderboardPage");
    }

    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        // Navigate to the SettingsPage
        await Shell.Current.GoToAsync("//SettingsPage");
    }
}
