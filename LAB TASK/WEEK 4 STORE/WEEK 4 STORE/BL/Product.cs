using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_4_STORE.BL
{
    class Product
    {
        public string name;
        public string category;
        public int price;
        public Product()
        {

        }
        public Product(string name, string category, int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public float calculateText(Customer cus)
        {
            List<Product> pro = cus.getAllProduct();
            float tax1 = 0.0f;
            float tax2 = 0.0f;
            float totalTax = 0.0f;
            foreach (Product storeP in pro)
            {
                if (storeP.category == "fruit")
                {
                    tax1 = storeP.price * (10.0f / 100.0f);
                    totalTax = tax1 + totalTax;
                }
                else if (storeP.category == "grocery")
                {
                    tax2 = storeP.price * (5.0f / 100.0f);
                    totalTax = tax2 + totalTax;
                }
            }
            return totalTax;
        }
    }
}
