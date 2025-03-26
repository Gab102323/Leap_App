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
            new ShopItem { Name = "Super Power Boost", Image="power_boost.png", Price="800 Coins", BuyCommand = new Command(() => BuyItem("Super Power Boost")) },
            new ShopItem { Name = "normal Skin", Image="cloth.png", Price="300 Coins", BuyCommand = new Command(() => BuyItem("normal Skin")) },
            new ShopItem { Name = "rare skin", Image="cloth.png", Price="600 Coins", BuyCommand = new Command(() => BuyItem("rare Skin")) },
            new ShopItem { Name = "100 Diamond", Image="diamond2.png", Price="50 coins", BuyCommand = new Command(() => BuyItem("100 Diamond")) },
            new ShopItem { Name = "200 Diamond", Image="diamond2.png", Price="100 Coins", BuyCommand = new Command(() => BuyItem("200 Diamond")) },
            new ShopItem { Name = "100 Coins", Image="coin_icon.png", Price="50 Coins", BuyCommand = new Command(() => BuyItem("100 Coins")) },
            new ShopItem { Name = "200 Coins", Image="coin_icon.png", Price="100 Coins", BuyCommand = new Command(() => BuyItem("200 Coins")) }
        };
        }

        private void BuyItem(string itemName)
        {
            Application.Current.MainPage.DisplayAlert("Purchase", $"{itemName} Purchased!", "OK");
        }
    }
}

