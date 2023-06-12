using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.DL;

namespace HMS_V6.UI
{
    class CustomerUI
    {
        public static void customerMenu()
        {
            Console.WriteLine("Main Menu >");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select one of the following options number...");
            Console.WriteLine("1- View Room Categories");
            Console.WriteLine("2- Online Booking");
            Console.WriteLine("3- Cancel Booking");
            Console.WriteLine("4- Change Password");
            Console.WriteLine("5- Give Reviews");
            Console.WriteLine("6- Give Ratings");
            Console.WriteLine("7- Logout");
            Console.WriteLine("8- Exit");
        }

        // Customer Functionality
        public static void customerInterface(ref int roomCount, ref bool exit_app)
        {
            string option_customer = "";
            while (true)
            {
                Interface.printHeader();
                customerMenu();
                option_customer = Interface.choice();
                if (option_customer == "1")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Room Categories");
                    RoomUI.roomType();
                    Interface.clear();
                }
                else if (option_customer == "2")
                {
                    Interface.printHeader();
                    Interface.subMenu("Online Booking");
                    ManagerUI.addCustomer(ref roomCount);
                    Interface.clear();
                }
                else if (option_customer == "3")
                {
                    Interface.printHeader();
                    Interface.subMenu("Cancel Booking");
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();
                    bool valid = Validation.isValid(customerName);
                    if (valid == true)
                    {
                        Console.Write("Enter Customer CNIC: ");
                        string customerId = Console.ReadLine();
                        bool id_valid = Validation.id_check(customerId);
                        if (id_valid == true)
                        {
                            Customer info = new Customer(customerName, customerId);
                            int isFound = CustomerDL.foundCustomer(info);
                            if (isFound == -1)
                            {
                                Console.WriteLine("Not Booked");
                            }
                            else
                            {
                                CustomerDL.removeCustomer(isFound);
                                CustomerDL.saveCustomerData();
                                Console.WriteLine("Booking Canceled");
                            }
                        }
                        else if (id_valid == false)
                        {
                            Interface.InvalidCNICFormat();
                        }
                    }
                    else if (valid == false)
                    {
                        Interface.NotValidName();
                    }
                    Interface.clear();
                }
                else if (option_customer == "4")
                {
                    Interface.printHeader();
                    Interface.subMenu("Change Password");
                    changePassword();
                }
                else if (option_customer == "5")
                {
                    Interface.printHeader();
                    Interface.subMenu("Give Reviews");
                    CustomerDL.customerReview();
                    Interface.clear();
                }
                else if (option_customer == "6")
                {
                    Interface.printHeader();
                    Interface.subMenu("Give Ratings");
                    CustomerDL.customerRating();
                    Interface.clear();
                }
                else if (option_customer == "7")
                {
                    break;
                }
                else if (option_customer == "8")
                {
                    exit_app = true;
                    break;
                }
                else
                {
                    Interface.wrongInput();
                    Interface.clear();
                }
            }
        }

        // Reviews 
        public static string addReview()
        {
            Console.WriteLine("Enter Review: ");
            string review = Console.ReadLine();
            return review;
        }
        public static void NoReviews()
        {
            Console.WriteLine("No Reviews");
        }
        public static void displayReviewList(string review)
        {
            Console.WriteLine("> " + review);
        }

        // Ratings
        public static void ratingMenu()
        {
            Console.WriteLine("1- One Star");
            Console.WriteLine("2- Two Star");
            Console.WriteLine("3- Three Star");
            Console.WriteLine("4- Four Star");
            Console.WriteLine("5- Five Star");
        }
        public static void NoRatings()
        {
            Console.WriteLine("No Ratings");
        }
        public static void displayRatingList(string rating)
        {
            Console.WriteLine("> " + rating);
        }

        // Change Password
        public static void changePassword()
        {
            int index = -1;
            bool isFound = false;
            bool exit = false;
            string newPassword2 = "";
            char back;
            while (true)
            {
                Interface.printHeader();
                Interface.subMenu("Change Password");
                Console.Write("Enter Old Password: ");
                string password = Console.ReadLine();
                bool valid1 = Validation.password_check(password);
                if (valid1 == true)
                {
                    index = UserDL.foundUser(password);
                    if (index != -1)
                    {
                        isFound = true;
                        Console.Write("Enter New Password: ");
                        string newPassword1 = Console.ReadLine();
                        bool valid2 = Validation.password_check(newPassword1);
                        if (valid2 == true)
                        {
                            bool isSame = UserDL.isPassowrdSame(newPassword1);
                            if (isSame == false)
                            {
                                if (newPassword1 == password)
                                {
                                    Console.WriteLine("Same as old password");
                                    Console.WriteLine("Try Again");
                                    Console.WriteLine("Enter (y) to continue or (n) for back: ");
                                    back = char.Parse(Console.ReadLine());
                                    if (back == 'y')
                                    {
                                        continue;
                                    }
                                    else if (back == 'n')
                                    {
                                        break;
                                    }
                                }
                                else if (newPassword1 != password)
                                {
                                    Console.Write("Confirm New Password: ");
                                    newPassword2 = Console.ReadLine();
                                    bool valid3 = Validation.password_check(newPassword2);
                                    if (valid3 == false)
                                    {
                                        UserUI.InvalidPassword();
                                        Interface.clear();
                                    }
                                }
                                if (newPassword2 == newPassword1)
                                {
                                    UserDL.changePassword(newPassword2, index);
                                    Console.WriteLine("Password Changed");
                                    UserDL.saveUserData();
                                    Interface.clear();
                                    break;
                                }
                                else if (newPassword2 != newPassword1)
                                {
                                    Console.WriteLine("Password Not Match");
                                    Console.WriteLine("Try Again");
                                    Console.WriteLine("Enter (y) to continue or (n) for back: ");
                                    back = char.Parse(Console.ReadLine());
                                    if (back == 'y')
                                    {
                                        continue;
                                    }
                                    else if (back == 'n')
                                    {
                                        break;
                                    }
                                }
                            }
                            else if(isSame == true)
                            {
                                UserUI.PasswordExists();
                                Interface.clear();
                            }
                        }
                        else if (valid2 == false)
                        {
                            UserUI.InvalidPassword();
                            Interface.clear();
                        }
                        if (exit == true)
                        {
                            break;
                        }
                        else if (isFound == false)
                        {
                            Console.WriteLine("Password Not Match");
                            Console.WriteLine("Try Again");
                            Console.WriteLine("Enter (y) to continue or (n) for back: ");
                            back = char.Parse(Console.ReadLine());
                            if (back == 'y')
                            {
                                continue;
                            }
                            else if (back == 'n')
                            {
                                break;
                            }
                        }
                    }
                    else if (index == -1)
                    {
                        UserUI.invalidUser();
                        Interface.clear();
                    }
                }
                else if (valid1 == false)
                {
                    UserUI.InvalidPassword();
                    Interface.clear();
                }
            }
        }
    }
}
