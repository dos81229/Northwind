//using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Northwind.DAL
{
   
    public class DBContext : IDisposable
    {
        private bool disposed = false;

        protected SqlConnection connection;

        public static string GetAppSettingStr(string key)
        {
            var secretKey = System.Configuration.ConfigurationManager.AppSettings[key];
            return secretKey;
        }
       
        public DBContext()
        {
            var connectionStr = WebConfigurationManager.ConnectionStrings["NorthwindContext"].ConnectionString;
            connection = new SqlConnection(connectionStr);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                connection.Dispose();
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}