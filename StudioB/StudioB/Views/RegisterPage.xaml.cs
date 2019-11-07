using System;
using StudioB.Models;
using StudioB.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using StudioB.Data;

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


            //App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_FName.Focus();
            Entry_FName.Completed += (s, e) => Entry_LName.Focus();
            Entry_LName.Completed += (s, e) => Entry_Email.Focus();
            Entry_Email.Completed += (s, e) => Entry_Password.Focus();
            //Entry_Password.IsEnabled = false;
            Entry_Password.Completed += (s, e) => RegisterProcedure(s, e);


        }

        public void SaveUser(object sender, EventArgs e)
        {
            if (Btn_Register.Text == "Register")
            {
                UserInfo userinfo = new UserInfo();
                userinfo.username = Entry_Username.Text;
                userinfo.firstname = Entry_FName.Text;
                userinfo.lastname = Entry_LName.Text;
                userinfo.emailad = Entry_Email.Text;
                userinfo.passw = Entry_Password.Text;
                //Entry_Password.IsEnabled = false;  


                bool res = DependencyService.Get<ISQLite>().SaveUser(userinfo);

                if(res)
                {
                    DisplayAlert("Register", "Registration successful", "Ok");
                    //Navigation.PopAsync(new MasterDetail (null));
                    Application.Current.MainPage = new NavigationPage(new MyPlants());
                }
                else
                {
                    DisplayAlert("Message", "Data Failed to Save", "Ok");
                }
            }
        }

        void RegisterProcedure(object sender, EventArgs e)
        {
            //UserInfo userInfo = new UserInfo()
            //{
            //    username = Entry_Username.Text,
            //    firstname = Entry_FName.Text,
            //    lastname = Entry_LName.Text,
            //    emailad = Entry_Email.Text,
            //    passw = Entry_Password.Text
            //};

            //if (userInfo.CheckInformation())

            //{
            //    using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            //    {
            //        conn.CreateTable<UserInfo>();
            //        int rowsAdded = conn.Insert(userInfo);
            //    }
            //    DisplayAlert("Register", "Registration successful", "Ok");
            //    Application.Current.MainPage = new NavigationPage(new MasterDetail());
            //}
            //else
            //{
            //    DisplayAlert("Login", "Login Not Correct, empty username or password.", "Ok");
            //}
           




        }

    }
}