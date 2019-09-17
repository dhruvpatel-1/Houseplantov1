using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace StudioB.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
