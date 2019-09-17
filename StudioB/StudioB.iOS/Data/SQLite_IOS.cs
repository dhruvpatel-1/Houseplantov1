using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using StudioB.Data;
using Xamarin.Forms;
using StudioB.iOS.Data;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace StudioB.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}