using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListBoxSQL
{
    public static class Helper
    {
        public static string GetConn(string name)
        {


            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
