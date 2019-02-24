using LoginApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Data
{
    public class LocalDatabase
    {
        readonly SQLiteAsyncConnection database;
        public LocalDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

        public bool LoginUserAsync(string email, string password)
        {
            var canLogin =  database.Table<User>().Where(u => u.Email == email && u.Password == password).FirstOrDefaultAsync();

            return canLogin.Id != 0;
        }
    }
}
