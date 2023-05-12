using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_5_Departmental_Store.BL;
using WEEK_5_Departmental_Store.DL;
using WEEK_5_Departmental_Store.UI;

namespace WEEK_5_Departmental_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                option = MUserUI.menu();
                if (option == 1)
                {
                    Console.Clear();
                    MUser user = MUserUI.signIn();
                    string role = MUserCRUD.isValid(user);
                    if (role == "admin")
                    {
                        do
                        {
                            Console.Clear();
                            option = ProductUI.AdminMenu();
                            if (option == 1)
                            {
                                Console.Clear();
                                ProductCRUD.addInToList(ProductUI.addProduct());
                            }
                            else if (option == 2)
                            {
                                Console.Clear();
                                ProductCRUD.viewProducts();
                            }
                            else if (option == 3)
                            {
                                Console.Clear();
                                ProductUI.viewHighestPrice(ProductCRUD.highestUnitPrice());
                            }
                            else if (option == 4)
                            {
                                Console.Clear();
                                ProductCRUD.salesTax();
                            }
                            else if (option == 5)
                            {
                                Console.Clear();
                                ProductCRUD.orderProduct();
                            }
                            Console.ReadKey();
                        }
                        while (option != 6);
                    }
                    else if (role == "customer")
                    {
                        Customer purchase = null;
                        do
                        {
                            Console.Clear();
                            option = CustomerUI.CustomerMenu();
                            if (option == 1)
                            {
                                Console.Clear();
                                ProductCRUD.viewProducts();
                            }
                            else if (option == 2)
                            {
                                Console.Clear();
                                purchase = CustomerUI.buyProduct();
                                bool isAvailable = ProductCRUD.isAvailable(purchase);
                                CustomerUI.foundProduct(isAvailable);
                            }
                            else if (option == 3)
                            {
                                Console.Clear();
                                ProductCRUD.calculateTax(purchase);
                            }
                            Console.ReadKey();
                        }
                        while (option != 4);
                    }
                }
                else if (option == 2)
                {
                    Console.Clear();
                    MUser user = MUserUI.signUp();
                    MUserCRUD.addInToList(user);
                }
                Console.ReadKey();
            }
            while (option != 3);
        }
    }
}
