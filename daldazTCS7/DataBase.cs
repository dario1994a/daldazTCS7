using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace daldazTCS7
{
    public interface DataBase
    {

        SQLiteAsyncConnection GetConnection();
    }
}
