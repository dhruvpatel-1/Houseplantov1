using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using StudioB.Data;
using StudioB.Models;

namespace StudioB.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPlants : ContentPage
    {
        public MyPlants()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            PopulateEmployeeList();
        }
        public void PopulateEmployeeList()
        {
            PlantList.ItemsSource = null;
            PlantList.ItemsSource = DependencyService.Get<ISQLite>().GetPlantInfos();
        }

        private void AddPlant(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPlantPage(null));
        }

        private void EditPlant(object sender, ItemTappedEventArgs e)
        {
            Plant details = e.Item as Plant;
            if (details != null)
            {
                Navigation.PushAsync(new AddPlantPage(details));
            }
        }

        private async void DeletePlant(object sender, EventArgs e)
        {
            bool res = await DisplayAlert("Message", "Do you want to delete this plant?", "Ok", "Cancel");
            if (res)
            {
                var menu = sender as MenuItem;
                Plant details = menu.CommandParameter as Plant;
                DependencyService.Get<ISQLite>().DeletePlant(details.Id);
                PopulateEmployeeList();
            }
        }
    }
}