using Leap_App.Views;

namespace Leap_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes
            Routing.RegisterRoute("SignInPage", typeof(SignInPage));
            Routing.RegisterRoute("HomePage_Main", typeof(HomePage));

            Routing.RegisterRoute("HomePage_Tab1", typeof(HomePage));
            Routing.RegisterRoute("ObjectivePage_Tab1", typeof(ObjectivePage));
            Routing.RegisterRoute("ShopPage_Tab1", typeof(ShopPage));
            Routing.RegisterRoute("LeaderboardPage_Tab1", typeof(LeaderboardPage));
        }
    }
}