using Microsoft.Maui.Controls;

namespace Leap_App.Views
{
    public partial class QuestionPage : ContentPage
    {
        private int currentLevel;

        public QuestionPage(int level)
        {
            InitializeComponent();
            currentLevel = level;
            LoadQuestion(level);
        }

        private void LoadQuestion(int level)
        {
            // Load the question and answers for the given level
            QuestionLabel.Text = $"Question for Level {level}";
        }

        private async void OnAnswerClicked(object sender, EventArgs e)
        {
            // Check if the answer is correct
            bool isCorrect = true; // Replace with actual logic

            if (isCorrect)
            {
                await DisplayAlert("Correct!", "You answered correctly.", "OK");
                await Navigation.PopAsync(); // Return to HomePage
                // Update the flag to the next level
            }
            else
            {
                await DisplayAlert("Wrong!", "Try again.", "OK");
            }
        }
    }
}