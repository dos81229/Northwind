using Dapper;
using Northwind.DAL.Model;
using Northwind.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.DAL
{
    public class CustomersDAO : DBContext
    {
        public CustomersDAO()
        {
            var dbConnectionString = AppHelper.GetAppSettingStr("NorthwindContext");

            var connection = ConfigurationManager.ConnectionStrings["NorthwindContext"].ConnectionString;

            var builder = new SqlConnectionStringBuilder(connection);

            //connection.Open();
        }

       

        public IEnumerable<Customers> GetCustomer()
        {
            string str = $"SELECT * FROM dbo.Customers";
            var query = connection.Query<Customers>(str);
            connection.Dispose();

            return query;
        }


        public Customers GetCustomer(string ID)
        {
            string str = $"SELECT * FROM dbo.Customers WHERE CustomerID ='{ID}' ";
            var query = connection.Query<Customers>(str).FirstOrDefault();
            connection.Dispose();

            return query;
        }
    }
}