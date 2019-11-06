using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudioB.Models;
using StudioB.Views.DetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioB.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listview; } }

        public List<MasterMenuItem> items;

        public MasterPage()
        {
            InitializeComponent();
            SetItems();
        }

        private void SetItems()
        {
            items = new List<MasterMenuItem>();
            items.Add(new MasterMenuItem("Plant1", "icon.png", Color.White, typeof(InfoScreen1)));
            items.Add(new MasterMenuItem("Plant2", "icon.png", Color.White, typeof(InfoScreen2)));
            items.Add(new MasterMenuItem("Update Profile", "icon.png", Color.White, typeof(ProfilePage)));
           

            ListView.ItemsSource = items;
        }
        private async void MenuItem_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Quit", "Are you sure you want to logout?", "OK");
            App.Current.MainPage = new MainPage();

        }
    }
}