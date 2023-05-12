using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Departmental_Store.BL;

namespace WEEK_5_Departmental_Store.UI
{
    class ProductUI
    {
        public static int AdminMenu()
        {
            Console.WriteLine("Select one option: ");
            Console.WriteLine("1- Add Product");
            Console.WriteLine("2- View All Product");
            Console.WriteLine("3- Find Product with the Highest Unit Price");
            Console.WriteLine("4- View Sales Tax of All Products");
            Console.WriteLine("5- Products to be Ordered");
            Console.WriteLine("6- Exit");
            Console.Write("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static Product addProduct()
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimun Stock Quantity: ");
            int minimumStock = int.Parse(Console.ReadLine());
            Product data = new Product(name, category, price, stock, minimumStock);
            return data;
        }
        public static void viewProducts(Product p)
        {
            Console.WriteLine("Product: " + p.name);
            Console.WriteLine("Category: " + p.category);
            Console.WriteLine("Price: " + p.price);
            Console.WriteLine("Stock: " + p.stock);
            Console.WriteLine();
        }
        public static void viewHighestPrice(Product p)
        {
            Console.WriteLine("Product: " + p.name);
            Console.WriteLine("Highest Unit Price: " + p.price);
        }
        public static void viewSalesTax(Product p)
        {
            Console.WriteLine("Product: " + p.name);
            if (p.category == "grocery")
            {
                Console.WriteLine("Sales Tax: 10%");
            }
            else if (p.category == "fruit")
            {
                Console.WriteLine("Sales Tax: 5%");
            }
            else
            {
                Console.WriteLine("Sales Tax: 15%");
            }
            Console.WriteLine();
        }
        public static void order(Product p)
        {
            Console.WriteLine("Product To Be Ordered: " + p.name);
            Console.WriteLine("Minimum Stock: " + p.minimumStock);
            Console.WriteLine();
        }
    }
}
