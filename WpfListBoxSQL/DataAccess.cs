using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// necasarias
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace WpfListBoxSQL
{
    public class DataAccess
    {
        public List<Customer> GetAllCustomers()
        {
            //throw new NotImplementedException();
            using (IDbConnection conn = new SqlConnection(Helper.GetConn("Conn1")))
            {
                var output = conn.Query<Customer>("select CustomerID,ContactName,City,Country from customers").ToList();
                return output;
            }

        }
        public List<Customer> GetCustomers(string name)
        {
            //throw new NotImplementedException();
            using (IDbConnection conn = new SqlConnection(Helper.GetConn("Conn1")))
            {
                var output = conn.Query<Customer>($"select CustomerID,ContactName,City,Country from customers where ContactName like '{name}%'").ToList();
                return output;
            }

        }
    }
}
