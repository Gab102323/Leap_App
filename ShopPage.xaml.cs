using System.Collections.ObjectModel;

namespace Leap_App.Views;
public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
        BindingContext = new ShopViewModel();
    }
           public class ShopItem
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }

        public Command BuyCommand { get; set; }
    }

    public class ShopViewModel
    {
        public ObservableCollection<ShopItem> ShopItems { get; set; }

        public ShopViewModel()
        {
            ShopItems = new ObservableCollection<ShopItem>
        {
            new ShopItem { Name = "Power Boost", Image="power_boost.png", Price="500 Coins", BuyCommand = new Command(() => BuyItem("Power Boost")) },
            new ShopItem { Name = "New Skin", Image="skin.png", Price="800 Coins", BuyCommand = new Command(() => BuyItem("New Skin")) },
            new ShopItem { Name = "XP Booster", Image="xp_booster.png", Price="300 Coins", BuyCommand = new Command(() => BuyItem("XP Booster")) },
            new ShopItem { Name = "Speed Boost", Image="speed_boost.png", Price="600 Coins", BuyCommand = new Command(() => BuyItem("Speed Boost")) }
        };
        }

        private void BuyItem(string itemName)
        {
            Application.Current.MainPage.DisplayAlert("Purchase", $"{itemName} Purchased!", "OK");
        }
    }
}

