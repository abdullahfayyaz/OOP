using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_3_Departmental_Store.BL;

namespace WEEK_3_Departmental_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Product p = new Product();
            string option = "";
            do
            {
                Console.Clear();
                menu();
                option = choice();
                if (option == "1")
                {
                    addProduct(product);
                }
                else if (option == "2")
                {
                    viewProducts(product);
                }
                else if (option == "3")
                {
                    highestPrice(product);
                }
                else if (option == "4")
                {
                    viewSalesTax(product);
                }
                else if (option == "5")
                {
                    orderProduct(product);
                }
            }
            while (option != "6");
        }
        static string choice()
        {
            string option = "";
            Console.Write("Enter Option: ");
            option = Console.ReadLine();
            return option;
        }
        static void menu()
        {
            Console.WriteLine("Select one option: ");
            Console.WriteLine("1- Add Product");
            Console.WriteLine("2- View All Product");
            Console.WriteLine("3- Find Product with the Highest Unit Price");
            Console.WriteLine("4- View Sales Tax of All Products");
            Console.WriteLine("5- Products to be Ordered");
            Console.WriteLine("6- Exit");
        }
        static void addProduct(List<Product> product)
        {
            Console.Clear();
            Product p = new Product();
            Console.Write("Enter Product Name: ");
            p.name = Console.ReadLine();
            Console.Write("Enter Product Category: ");
            p.category = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            p.price = int.Parse(Console.ReadLine());
            Console.Write("Enter Stock Quantity: ");
            p.stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimun Stock Quantity: ");
            p.minimumStock = int.Parse(Console.ReadLine());
            product.Add(p);
        }
        static void viewProducts(List<Product> product)
        {
            Console.Clear();
            if (product.Count == 0)
            {
                Console.WriteLine("No Products");
            }
            else
            {
                for (int i = 0; i < product.Count(); i++)
                {
                    Product p = new Product();
                    p = product[i];
                    Console.WriteLine("Product " + (i + 1) + ": " + p.name);
                }
            }
            Console.ReadKey();
        }
        static void highestPrice(List<Product> product)
        {
            Console.Clear();
            Product s = new Product();
            string highest = s.highest(product);
            Console.WriteLine("Product with Highest Unit Price: " + highest);
            Console.ReadKey();
        }
        static void viewSalesTax(List<Product> product)
        {
            float taxes;
            Console.Clear();
            for (int x = 0; x < product.Count; x++)
            {
                Product s = new Product();
                taxes = s.taxPrice(product[x]);
                Console.WriteLine(" Tax Price is: " + taxes);

            }
            Console.ReadKey();
        }
        static void orderProduct(List<Product> product)
        {
            Console.Clear();
            string ordered;
            for (int x = 0; x < product.Count; x++)
            {
                Product s = new Product();
                ordered = s.order(product[x]);
                if (ordered != " ")
                {
                    Console.WriteLine("You want to order a product " + ordered);
                }
            }
            Console.ReadKey();
        }
    }
}
