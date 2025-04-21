namespace Leap_App.Views
{
    public partial class LeaderboardPage : ContentPage
    {
        public List<LeaderboardEntry> LeaderboardEntries { get; set; }

        public LeaderboardPage()
        {
            InitializeComponent();

            // Sample data for leaderboard
            LeaderboardEntries = new List<LeaderboardEntry>
            {
                new LeaderboardEntry { Rank = 1, Name = "Player1", Score = 529, ProfileImage = "profile_icon.png" },
                new LeaderboardEntry { Rank = 2, Name = "Player2", Score = 500, ProfileImage = "profile_icon.png" },
                new LeaderboardEntry { Rank = 3, Name = "Player3", Score = 498, ProfileImage = "profile_icon.png" },
                new LeaderboardEntry { Rank = 4, Name = "Player4", Score = 485, ProfileImage = "profile_icon.png" },
                new LeaderboardEntry { Rank = 5, Name = "Player5", Score = 462, ProfileImage = "profile_icon.png" },
                new LeaderboardEntry { Rank = 6, Name = "Player6", Score = 450, ProfileImage = "profile_icon.png" },
                new LeaderboardEntry { Rank = 7, Name = "Player7", Score = 408, ProfileImage = "profile_icon.png" }
            };

            BindingContext = this;
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
            await Shell.Current.GoToAsync("//ObjectivePage");
        }

        private async void GoToLeaderboard(object sender, EventArgs e)
        {
            // Stay on the current page
        }
    }

    public class LeaderboardEntry
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string ProfileImage { get; set; }
    }
}