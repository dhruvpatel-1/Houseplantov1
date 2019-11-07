using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StudioB.Models;
using StudioB.Data;

namespace StudioB.Views.DetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateProfile : ContentPage
    {
        UserInfo UserDeatils;
        public UpdateProfile(UserInfo details)
        {
            InitializeComponent();

            if (details != null)
            {
                UserDeatils = details;
                PopulateDetails(UserDeatils);
            }
        }

        private void PopulateDetails(UserInfo details)
        {
            firstname.Text = details.firstname;
            lastname.Text = details.lastname;
            Email.Text = details.emailad;
            Password.Text = details.passw;
            //Password.IsEnabled = false;
            saveBtn.Text = "Update";
            this.Title = "Edit Profile";
        }

        private void SavePlant(object sender, EventArgs e)
        {
                // update employee
                UserDeatils.firstname = firstname.Text;
                UserDeatils.lastname = lastname.Text;
                UserDeatils.emailad = Email.Text;
                UserDeatils.passw = Password.Text;


                bool res = DependencyService.Get<ISQLite>().UpdateUser(UserDeatils);
                if (res)
                {
                    DisplayAlert("Notification", "User updated successful", "Ok");
                    Navigation.PopAsync();
                    
                }
                else
                {
                    DisplayAlert("Message", "Data Failed To Update", "Ok");
                }
           
        }


    }
}