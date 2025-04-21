using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Leap_App.Views
{
    public partial class HomePage : ContentPage
    {
        private int currentLevel = 1; // Tracks the current level
        public ObservableCollection<Level> Levels { get; set; } // Collection of levels

        public HomePage()
        {
            InitializeComponent();

            // Initialize levels
            Levels = new ObservableCollection<Level>();
            for (int i = 1; i <= 50; i++)
            {
                Levels.Add(new Level
                {
                    LevelNumber = i,
                    IsCurrentLevel = i == currentLevel
                });
            }

            // Bind levels to the UI
            LevelsCollectionView.ItemsSource = Levels;

            // Load user data (e.g., coins, diamonds, etc.)
            CoinsLabel.Text = "0";
            DiamondsLabel.Text = "0";
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            // Navigate to Profile Page
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            // Navigate to Settings Page
            await Navigation.PushAsync(new SettingsPage());
        }

        private void OnLevelTapped(object sender, EventArgs e)
        {
            // Show the Play button only for the current level
            var tappedLevel = (sender as Frame)?.BindingContext as Level;
            if (tappedLevel != null && tappedLevel.IsCurrentLevel)
            {
                PlayButton.IsVisible = true;
            }
        }

        private async void OnPlayClicked(object sender, EventArgs e)
        {
            // Navigate to the question page for the current level
            await Navigation.PushAsync(new QuestionPage(currentLevel));
        }

        public void AdvanceToNextLevel()
        {
            // Move the flag to the next level
            if (currentLevel < 50)
            {
                Levels[currentLevel - 1].IsCurrentLevel = false; // Reset current level
                currentLevel++;
                Levels[currentLevel - 1].IsCurrentLevel = true; // Set new current level
                PlayButton.IsVisible = false; // Hide Play button
            }
        }
        private async void GoToHome(object sender, EventArgs e)
        {
            // Navigate to the HomePage (if needed)
            await Navigation.PushAsync(new HomePage());
        }

        private async void GoToShop(object sender, EventArgs e)
        {
            // Navigate to the ShopPage
            await Navigation.PushAsync(new ShopPage());
        }

        private async void GoToObjectives(object sender, EventArgs e)
        {
            // Navigate to the ObjectivePage
            await Navigation.PushAsync(new ObjectivePage());
        }

        private async void GoToLeaderboard(object sender, EventArgs e)
        {
            // Navigate to the LeaderboardPage
            await Navigation.PushAsync(new LeaderboardPage());
        }
    }

    // Model for levels
    public class Level
    {
        public int LevelNumber { get; set; }
        public bool IsCurrentLevel { get; set; }
    }
}