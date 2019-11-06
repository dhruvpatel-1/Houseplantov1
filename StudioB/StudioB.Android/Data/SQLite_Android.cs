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

            con.DeleteAll<Plant>();
            con.DeleteAll<UserInfo>();
            con.CreateTable<UserInfo>();
            con.CreateTable<Plant>();
            return con;

        }

        public bool SavePlant(Plant employee)
        {
            bool res = false;
            try
            {
                con.Insert(employee);
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;
        }

        public List<Plant> GetPlantInfos()
        {
            string sql = "SELECT * FROM Plant";
            List<Plant> employees = con.Query<Plant>(sql);
            return employees;
        }


        public bool UpdatePlant(Plant plant)
        {
            bool res = false;
            try
            {
                string sql = $"UPDATE Plant SET PlantName='{plant.PlantName}',PlantType='{plant.PlantType}' " +
                                $" WHERE Id={plant.Id}";
                con.Execute(sql);
                res = true;
            }
            catch (Exception ex)
            {

            }
            return res;
        }

        public void DeletePlant(int Id)
        {
            string sql = $"DELETE FROM Plant WHERE Id={Id}";
            con.Execute(sql);
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
            bool res = false;
            try
            {
                string sql = $"UPDATE UserInfo SET firstname='{userInfo.firstname}',lastname='{userInfo.lastname}',emailad='{userInfo.emailad}'," +
                                $"passw='{userInfo.passw}' WHERE Id={userInfo.id}";
                con.Execute(sql);
                res = true;
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}