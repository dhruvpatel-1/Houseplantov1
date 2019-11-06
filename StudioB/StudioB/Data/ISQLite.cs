using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using StudioB.Models;

namespace StudioB.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();

        bool SaveUser(UserInfo userinfo);
        bool SavePlant(Plant plant);

        List<UserInfo> GetUserInfos();

        List<Plant> GetPlantInfos();

        bool UpdateUser(UserInfo userInfo);

        bool UpdatePlant(Plant plant);

        void DeletePlant(int Id);

    }
}
