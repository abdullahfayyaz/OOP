using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Departmental_Store.BL;

namespace WEEK_5_Departmental_Store.UI
{
    class CustomerUI
    {
        public static int CustomerMenu()
        {
            Console.WriteLine("1. View all the products");
            Console.WriteLine("2. Buy the products");
            Console.WriteLine("3. Generate invoice");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static Customer buyProduct()
        {
            Console.Write("Enter Product Name: ");
            string product = Console.ReadLine();
            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Customer purchase = new Customer(product, quantity);
            return purchase;
        }
        public static void foundProduct(bool check)
        {
            if (check == true)
            {
                Console.WriteLine("Thank You!");
            }
            else
            {
                Console.WriteLine("Product is not available");
            }
        }
        public static void generateInvoice(Product p, float tax)
        {
            Console.WriteLine("Product: " + p.name);
            Console.WriteLine("Category: " + p.category);
            Console.WriteLine("Price: " + p.price);
            if (p.category == "grocery")
            {
                Console.WriteLine("Sales Tax: 10%");
            }
            if (p.category == "fruit")
            {
                Console.WriteLine("Sales Tax: 5%");
            }
            else
            {
                Console.WriteLine("Sales Tax: 15%");
            }
            Console.WriteLine("Price After Sales Tax: " + tax);
        }
    }
}
