using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Departmental_Store.BL;
using WEEK_5_Departmental_Store.UI;

namespace WEEK_5_Departmental_Store.DL
{
    class ProductCRUD
    {
        static List<Product> productList = new List<Product>();
        public static void addInToList(Product data)
        {
            productList.Add(data);
        }
        public static void viewProducts()
        {
            for (int x = 0; x < productList.Count(); x++)
            {
                ProductUI.viewProducts(productList[x]);
            }
        }
        public static Product highestUnitPrice()
        {
            int highestPrice = 0;
            string name = "";
            for (int x = 0; x < productList.Count(); x++)
            {
                if (highestPrice < productList[x].price)
                {
                    highestPrice = productList[x].price;
                    name = productList[x].name;
                }
            }
            Product data = new Product(name, highestPrice);
            return data;
        }
        public static void salesTax()
        {
            for (int x = 0; x < productList.Count(); x++)
            {
                ProductUI.viewSalesTax(productList[x]);
            }
        }
        public static void orderProduct()
        {
            for (int x = 0; x < productList.Count(); x++)
            {
                if (productList[x].minimumStock < 10)
                {
                    ProductUI.order(productList[x]);
                }
            }
        }
        public static bool isAvailable(Customer c)
        {
            bool check = false;
            for (int x = 0; x < productList.Count(); x++)
            {
                if (c.productName == productList[x].name)
                {
                    productList[x].stock -= c.quantity;
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        public static void calculateTax(Customer c)
        {
            float tax = 0.0F;
            for (int x = 0; x < productList.Count(); x++)
            {
                if (c.productName == productList[x].name)
                {
                    if (productList[x].category == "grocery")
                    {
                        tax = productList[x].price + (productList[x].price * c.quantity * 10 / 100);
                        CustomerUI.generateInvoice(productList[x], tax);
                        break;
                    }
                    if (productList[x].category == "fruit")
                    {
                        tax = productList[x].price + (productList[x].price * c.quantity * 5 / 100);
                        CustomerUI.generateInvoice(productList[x], tax);
                        break;
                    }
                    else
                    {
                        tax = productList[x].price + (productList[x].price * c.quantity * 15 / 100);
                        CustomerUI.generateInvoice(productList[x], tax);
                        break;
                    }
                }
            }
        }
    }
}
