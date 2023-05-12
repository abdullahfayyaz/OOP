using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_3_Departmental_Store.BL
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
        public Product(Product p)
        {
            name = p.name;
            category = p.category;
            price = p.price;
            stock = p.stock;
            minimumStock = p.minimumStock;
        }
        public string highest(List<Product> p)
        {
            int highest = 0;
            string name = "";
            for (int x = 0; x < p.Count; x++)
            {
                if (highest < p[x].price)
                {
                    highest = p[x].price;
                    name = p[x].name;
                }
            }
            return name;
        }
        public float taxPrice(Product s)
        {
            float tax = 0;

            if (s.category == "grocery")
            {
                tax = s.price * 10 / 100;
            }
            if (s.category == "fruits")
            {
                tax = s.price * 5 / 100;
            }
            else
            {
                tax = s.price * 15 / 100;
            }
            return tax;
        }
        public string order(Product s)
        {
            string order = " ";
            if (s.minimumStock < 10)
            {
                order = s.name;
            }
            return order;
        }
    }
}
