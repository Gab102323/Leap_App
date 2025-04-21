namespace Leap_App.Views
{
    public partial class ObjectivePage : ContentPage
    {
        public ObjectivePage()
        {
            InitializeComponent();
        }
        private async void GoToHome(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage_Main");
        }

        private async void GoToShop(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//ShopPage");
        }

        private async void GoToObjectives(object sender, EventArgs e)
        {
            // Stay on the current page
        }

        private async void GoToLeaderboard(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LeaderboardPage");
        }
    }
}