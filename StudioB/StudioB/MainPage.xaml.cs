using StudioB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace StudioB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

        }
        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            NavigationPage navigationRootPage = new NavigationPage(new LoginPage());
            navigationRootPage.BarTextColor = Color.White;
            App.Current.MainPage = navigationRootPage;

            //await this.Navigation.PushAsync(new LoginPage());
        }
        private void SignUp_Clicked(object sender, EventArgs e)
        {

            NavigationPage navigationRootPage = new NavigationPage(new RegisterPage());
            navigationRootPage.BarTextColor = Color.White;
            App.Current.MainPage = navigationRootPage;
            // await Navigation.PushAsync(new RegisterPage());
        }
    }
}