using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace StudioB.Models
{

    public class UserInfo
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string emailad { get; set; }
        public string passw { get; set; }

        public bool CheckInformation()
        {
            if (username != null && firstname != null && lastname != null && emailad != null && passw != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

   
}
