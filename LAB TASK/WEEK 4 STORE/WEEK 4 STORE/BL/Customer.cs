using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_4_STORE.BL
{
    class Customer
    {
        public string custmerName;
        public string custmerAdress;
        public string custmerContact;
        public List<Product> products = new List<Product>();
        public Customer()
        {

        }
        public Customer(string name, string address, string contact)
        {
            this.custmerName = name;
            this.custmerAdress = address;
            this.custmerContact = contact;
        }
        public List<Product> getAllProduct()
        {
            return products;
        }
        public void storeInList(Product p)
        {
            products.Add(p);
        }
    }
}
