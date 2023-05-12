using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_Departmental_Store.BL
{
    class Customer
    {
        public string productName;
        public int quantity;
        public Customer()
        {

        }
        public Customer(string productName, int quantity)
        {
            this.productName = productName;
            this.quantity = quantity;
        }
    }
}
