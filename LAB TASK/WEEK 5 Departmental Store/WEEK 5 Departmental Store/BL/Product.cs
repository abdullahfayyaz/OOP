using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_5_Departmental_Store.BL
{
    class Product
    {
        public string name;
        public string category;
        public int price;
        public int stock;
        public int minimumStock;
        public Product()
        {

        }
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public Product(string name, string category, int price, int stock, int minimumStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.minimumStock = minimumStock;
        }
    }
}
