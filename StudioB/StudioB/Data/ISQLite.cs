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

        List<UserInfo> GetUserInfos();

        bool UpdateUser(UserInfo userInfo);


    }
}
