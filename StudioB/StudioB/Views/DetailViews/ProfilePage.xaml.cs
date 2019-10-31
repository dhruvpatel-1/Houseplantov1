using System;
using StudioB.Models;
using StudioB.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioB.Views.DetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            Init();

        }
        void Init()
        {
            Lbl_Password.TextColor = Constants.MainTextColor;
            Lbl_Email.TextColor = Constants.MainTextColor;
            Lbl_FName.TextColor = Constants.MainTextColor;
            Lbl_LName.TextColor = Constants.MainTextColor;


            ActivitySpinner.IsVisible = false;



            App.StartCheckIfInternet(lbl_NoInternet, this);


        }
        async void UpdateProfile(object sender, EventArgs e)
        {
            User user = new User(Entry_Email.Text, Entry_Password.Text);

            if (user.CheckInformation())
            {
                DisplayAlert("Update", "Details Updated", "Ok");
                //Token token = await App.RestService.Login(user);
                var result = new Token();
                if (result != null)
                {
                    // App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(token);

                    //  await DisplayAlert("Login", "Login Success", "Ok");

                    if (Device.OS == TargetPlatform.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new MasterDetail());
                    }
                    else if (Device.OS == TargetPlatform.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new MasterDetail()));
                    }
                    //else
                    //{
                    //    await Navigation.PushAsync(new MasterDetail()); // might not work for UWP
                    //}
                }
            }
            else
            {
                await DisplayAlert("Update", "Data Not Correct, empty fields.", "Ok");
            }
        }
    }
}