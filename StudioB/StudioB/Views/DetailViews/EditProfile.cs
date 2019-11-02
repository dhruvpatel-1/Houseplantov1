using StudioB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.IO;


namespace StudioB.Views.DetailViews
{
    public class EditProfile : ContentPage
    {

        private ListView _listview;
        private Entry _nameentry;
        private Entry _identry;
        private Entry _firstnameentry;
        private Entry _lastnameentry;
        private Entry _emailaddressentry;
        private Entry _passwordentry;
        private Button _button;

        UserInfo _userinfo = new UserInfo();


        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "TestDB.db3");

        public EditProfile()
        {
            this.Title = "Edit Profile";

            var db = new SQLiteConnection(_dbPath);

            StackLayout stackLayout = new StackLayout();

            _listview = new ListView();
            _listview.ItemsSource = db.Table<UserInfo>().ToList();
            _listview.ItemSelected += _listview_ItemSelected;
            stackLayout.Children.Add(_listview);

            _identry = new Entry();
            _identry.Placeholder = "ID";
            _identry.IsVisible = false;
            stackLayout.Children.Add(_identry);

            _firstnameentry = new Entry();
            _firstnameentry.Keyboard = Keyboard.Text;
            _firstnameentry.Placeholder = "First Name";
            stackLayout.Children.Add(_nameentry);

            _lastnameentry = new Entry();
            _lastnameentry.Keyboard = Keyboard.Text;
            _lastnameentry.Placeholder = "Last Name";
            stackLayout.Children.Add(_nameentry);

            _emailaddressentry = new Entry();
            _emailaddressentry.Keyboard = Keyboard.Text;
            _emailaddressentry.Placeholder = "Email";
            stackLayout.Children.Add(_emailaddressentry);

            _passwordentry = new Entry();
            _passwordentry.Keyboard = Keyboard.Text;
            _passwordentry.Placeholder = "Password";
            stackLayout.Children.Add(_passwordentry);

            _button = new Button();
            _button.Text = "Update";
            _button.Clicked += _button_clicked;
            stackLayout.Children.Add(_button);


        }

        private async void _button_clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            UserInfo userInfo = new UserInfo()
            {
                username = _identry.Text,
                firstname = _firstnameentry.Text,
                lastname = _lastnameentry.Text,
                emailad = _emailaddressentry.Text,
                passw = _passwordentry.Text
            };
            db.Update(userInfo);

            await Navigation.PopAsync();
        }

        private void _listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            _userinfo = (UserInfo)e.SelectedItem;
            _identry.Text = _userinfo.id.ToString();
        }
    }
}