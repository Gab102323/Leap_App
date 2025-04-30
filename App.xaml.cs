using Leap_App.Views;

namespace Leap_App
{
    public partial class App : Application
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
                Console.WriteLine($"IsLoggedIn: {isLoggedIn}");

                // Navigate based on login status
                MainPage.Dispatcher.Dispatch(async () =>
                {
                    try
                    {
                        if (isLoggedIn)
                        {
                            Console.WriteLine("Navigating to MainHomePage");
                            await Shell.Current.GoToAsync("//MainHomePage");
                        }
                        else
                        {
                            Console.WriteLine("Navigating to SignInPage");
                            await Shell.Current.GoToAsync("//SignInPage");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Navigation error: {ex.Message}");
                    }
                });
            }
        }

    }

}