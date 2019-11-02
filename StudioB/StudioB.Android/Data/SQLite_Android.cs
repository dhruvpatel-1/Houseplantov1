using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StudioB.Data;
using System.IO;
using Xamarin.Forms;
using StudioB.Droid.Data;
using SQLite;
using StudioB.Models;

[assembly: Dependency(typeof(SQLite_Android))]

namespace StudioB.Droid.Data
{
    class SQLite_Android : ISQLite
    {

        SQLiteConnection con;
        //public SQLite_Android() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            con = new SQLite.SQLiteConnection(path);
            con.CreateTable<UserInfo>();
            return con;

        }

        public List<UserInfo> GetUserInfos()
        {
            string sql = "SELECT * FROM UserInfo";
            List<UserInfo> userInfos = con.Query<UserInfo>(sql);
            return userInfos;
        }

        public bool SaveUser(UserInfo userinfo)
        {
            bool res = false;
            try
            {
                con.Insert(userinfo);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;

            }
            return res;
            
        }

        public bool UpdateUser(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }
    }
}