using System;
using SQLite;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace StudioB.Models
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }
        public int expire_in { get; set; }
        public Token() { }
    }
}
