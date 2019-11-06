using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace StudioB.Models
{
    public class Plant
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string PlantName { get; set; }
        public string PlantType { get; set; }
    }
}
