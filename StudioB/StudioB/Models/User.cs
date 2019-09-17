using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace StudioB.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User () { }
        public User (string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            if (Username != null && Password != null)
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
