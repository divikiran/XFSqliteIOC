using System;
using SQLite.Net.Async;

namespace XFSqliteIOC
{
    public interface ISQLiteConnection
    {
        SQLiteAsyncConnection GetConnectionAsync();
    }
}
