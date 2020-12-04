using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TesteThomasGreg.Database
{
    class Connection
    {
        private static SQLiteConnection sqliteConnection;
        private static string path = Directory.GetCurrentDirectory() + "\\acme.sqlite";

        public SQLiteConnection DbConnection()
        {
            try
            {
                CreateDataBaseSQLite();

                sqliteConnection = new SQLiteConnection("Data Source=" + path + "; Version=3;");
                sqliteConnection.Close();
                sqliteConnection.Open();
                return sqliteConnection;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void CreateDataBaseSQLite()
        {
            try
            {
                if (!File.Exists(path))
                {

                    SQLiteConnection.CreateFile(path);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
