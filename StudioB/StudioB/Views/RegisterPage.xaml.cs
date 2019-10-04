using System;
using StudioB.Models;
using StudioB.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudioB.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            Lbl_Email.TextColor = Constants.MainTextColor;
            Lbl_FName.TextColor = Constants.MainTextColor;
            Lbl_LName.TextColor = Constants.MainTextColor;
           

            ActivitySpinner.IsVisible = false;

            

            App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedure(s, e);
        }
        async void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);

            if (user.CheckInformation())
            {
                DisplayAlert("Register", "Register Success", "Ok");
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
                await DisplayAlert("Register", "Register Not Correct, empty username or password.", "Ok");
            }
        }
    }
}