using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfListBoxSQL
{
    public class Customer
    {
        public string CustomerID { get; set; }

        public string ContactName { get; set; }
        public string City { get; set; }

        public string Country { get; set; }


        public string FullInfo
        {
            get 
            { 
                return $"{ContactName} - { City } - {Country}"; 
            }
        }


    }
}
