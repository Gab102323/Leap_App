using Leap_App.Views;

namespace Leap_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the MainPage to AppShell
            MainPage = new AppShell();

            // Check if the user is logged in
            bool isLoggedIn = Preferences.Get("IsLoggedIn", false);

            // Delay navigation until the MainPage is fully initialized
            MainPage.Dispatcher.Dispatch(async () =>
            {
                try
                {
                    if (isLoggedIn)
                    {
                        // Navigate to HomePage using a relative route
                        await Shell.Current.GoToAsync("HomePage_Main");
                    }
                    else
                    {
                        // Navigate to SignInPage using a relative route
                        await Shell.Current.GoToAsync("SignInPage");
                    }
                }
                catch (Exception ex)
                {
                    // Handle navigation exceptions
                    Console.WriteLine($"Navigation error: {ex.Message}");
                }
            });
        }
    }
}