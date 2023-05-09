using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_4_STORE.BL;

namespace WEEK_4_STORE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Product> product = new List<Product>();
            int option;
            Customer customer = new Customer();
            Product products = new Product();

            do
            {
                Console.Clear();
                option = menu();
                if (option == 1)
                {
                    Console.Clear();
                    customer = takeInPutForInformation();
                    storeInformationInList(customers, customer);
                    Console.ReadKey();

                }
                else if (option == 2)
                {
                    Console.Clear();
                    products = addProducts();
                    customer.storeInList(products);
                    Console.ReadKey();

                }
                else if (option == 3)
                {
                    Console.Clear();
                    viewCustmerInformation(customers);
                    Console.ReadKey();

                }
                else if (option == 4)
                {
                    Console.Clear();
                    product = customer.getAllProduct();
                    viewAllProduct(product);
                    Console.ReadKey();

                }
                else if (option == 5)
                {
                    Console.Clear();
                    float tax = products.calculateText(customer);
                    viewTax(tax);
                    Console.ReadKey();
                }
            }
            while (option != 6);
            Console.ReadKey();
        }
        static int menu()
        {
            Console.WriteLine("1.enter information of custmer:");
            Console.WriteLine("2.enter products:");
            Console.WriteLine("3.view custmer information:");
            Console.WriteLine("4.view total purchased:");
            Console.WriteLine("5.calculate tax:");
            Console.WriteLine("6.exit:");
            int option = int.Parse(Console.ReadLine());
            return option;

        }
        static Customer takeInPutForInformation()
        {
            Console.WriteLine("enter your name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("enter your contact number: ");
            string customerContact = Console.ReadLine();
            Console.WriteLine("enter your adress: ");
            string customerAdress = Console.ReadLine();
            Customer customer = new Customer(customerName, customerAdress, customerContact);
            return customer;

        }
        static void storeInformationInList(List<Customer> cus, Customer custmer)
        {
            cus.Add(custmer);
        }
        static Product addProducts()
        {
            Console.WriteLine("enter product name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter product category:");
            string category = Console.ReadLine();
            Console.WriteLine("enter product price:");
            int price = int.Parse(Console.ReadLine());
            Product products = new Product(name, category, price);
            return products;
        }
        static void viewCustmerInformation(List<Customer> custmers)
        {
            Console.WriteLine("name\t\tcontact\t\t\tadress:");
            foreach (Customer storedCust in custmers)
            {
                Console.WriteLine(storedCust.custmerName + "\t\t" + storedCust.custmerContact + "\t\t" + storedCust.custmerAdress);
            }
        }
        static void viewAllProduct(List<Product> pro)
        {
            Console.WriteLine("name\t\tCetagory\t\t\tprice:");
            foreach (Product storedPro in pro)
            {
                Console.WriteLine(storedPro.name + "\t\t" + storedPro.category + "\t\t" + storedPro.price);
            }
        }
        static void viewTax(float tax)
        {
            Console.WriteLine("total tax is:" + tax);
        }
    }
}
