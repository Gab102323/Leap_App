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

    private void GoToLeaderboard(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//LeaderboardPage");
    }

}