using System;
using StudioB.Models;
using StudioB.Views.Menu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Linq;
using StudioB.Data;

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

        protected override void OnAppearing()
        {
            PopulateUserList();
        }

        public void PopulateUserList()
        {
            userinfoview.ItemsSource = null;
            userinfoview.ItemsSource = DependencyService.Get<ISQLite>().GetUserInfos();
        }
        void Init()
        {
            //Lbl_Password.TextColor = Constants.MainTextColor;
            //Lbl_Email.TextColor = Constants.MainTextColor;
            //Lbl_FName.TextColor = Constants.MainTextColor;
            //Lbl_LName.TextColor = Constants.MainTextColor;






        }

        private void EditPlant(object sender, ItemTappedEventArgs e)
        {
            UserInfo details = e.Item as UserInfo;
            if (details != null)
            {
                Navigation.PushAsync(new UpdateProfile(details));
            }
        }
        void UpdateProfile(object sender, System.EventArgs e)
        {
            //UserInfo userInfo = new UserInfo()
            //{
            //    firstname = Entry_FName.Text,
            //    lastname = Entry_LName.Text,
            //    emailad = Entry_Email.Text,
            //    passw = Entry_Password.Text
            //};

            //using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            //{
            //    int rowsAdded = conn.Update(userInfo);
            //}
        }

        
    }
}