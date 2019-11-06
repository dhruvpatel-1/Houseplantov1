using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StudioB.Models;
using StudioB.Data;

namespace StudioB.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPlantPage : ContentPage
    {
        Plant PlantDetails;
        public AddPlantPage(Plant details)
        {
            InitializeComponent();

            if (details != null)
            {
                PlantDetails = details;
                PopulateDetails(PlantDetails);
            }
        }

        private void PopulateDetails(Plant details)
        {
            plantname.Text = details.PlantName;
            planttype.Text = details.PlantType;
            saveBtn.Text = "Update";
            this.Title = "Edit Employee";
        }

        private void SavePlant(object sender, EventArgs e)
        {
            if (saveBtn.Text == "Save")
            {
                Plant plant = new Plant();
                plant.PlantName = plantname.Text;
                plant.PlantType = planttype.Text;
                
                bool res = DependencyService.Get<ISQLite>().SavePlant(plant);
                if (res)
                {
                    Navigation.PopAsync();
                    DisplayAlert("Notification", "Plant added successful", "Ok");
                }
                else
                {
                    DisplayAlert("Message", "Data Failed To Save", "Ok");
                }
            }
            else
            {
                // update employee
                PlantDetails.PlantName = plantname.Text;
                PlantDetails.PlantType = planttype.Text;
         

                bool res = DependencyService.Get<ISQLite>().UpdatePlant(PlantDetails);
                if (res)
                {
                    Navigation.PopAsync();
                    DisplayAlert("Notification", "Plant updated successful", "Ok");
                }
                else
                {
                    DisplayAlert("Message", "Data Failed To Update", "Ok");
                }
            }
        }
    }
    
}