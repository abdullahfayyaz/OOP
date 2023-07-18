using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_FINAL.BL;
using HMS_FINAL.DL;

namespace HMS_FINAL.UI
{
    class CustomerUI
    {
        public static void customerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Main Menu >");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Select one of the following options number...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1- View Room Categories");
            Console.WriteLine("2- Online Booking");
            Console.WriteLine("3- Cancel Booking");
            Console.WriteLine("4- Change Password");
            Console.WriteLine("5- Give Reviews");
            Console.WriteLine("6- Give Ratings");
            Console.WriteLine("7- Logout");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("8- Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Customer Functionality
        public static void customerInterface()
        {
            string option_customer;
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
                    ManagerUI.addCustomer();
                    Interface.clear();
                }
                else if (option_customer == "3")
                {
                    Interface.printHeader();
                    Interface.subMenu("Cancel Booking");
                    cancelBooking();
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
                    giveReview();
                    Interface.clear();
                }
                else if (option_customer == "6")
                {
                    Interface.printHeader();
                    Interface.subMenu("Give Ratings");
                    giveRating();
                    Interface.clear();
                }
                else if (option_customer == "7")
                {
                    break;
                }
                else if (option_customer == "8")
                {
                    Extra.exit_app = true;
                    break;
                }
                else
                {
                    Interface.wrongInput();
                    Interface.clear();
                }
            }
        }

        public static int customerIndex()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter Customer Name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string customerName = Console.ReadLine();
            bool valid = Validation.isValid(customerName);
            if (valid == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter Customer CNIC: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string customerId = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                bool id_valid = Validation.id_check(customerId);
                if (id_valid == true)
                {
                    Customer info = new Customer(customerName, customerId);
                    int isFound = PersonDL.foundCustomer(info);
                    return isFound;
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
            return -2;
        }


        // Reviews 
        public static string addReview()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter Review: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string review = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return review;
        }
        public static void NoReviews()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("No Reviews");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void displayReview(Person info)
        {
            if (info.getRole() == "Customer")
            {
                if (info.getReviewCheck() == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("> ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(info.getName() + ": ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(info.getReview());
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        // Ratings
        public static void ratingMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("1- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("One Star");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("2- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Two Star");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("3- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Three Star");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("4- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Four Star");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("5- ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Five Star");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NoRatings()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("No Ratings");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void displayRating(Person info)
        {
            if (info.getRole() == "Customer")
            {
                if (info.getRatingCheck() == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("> ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(info.getName() + ": ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(info.getRating());
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        // Cancel Booking
        public static void cancelBooking()
        {
            int index = customerIndex();
            if (index == -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Not Booked");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (index != -2)
            {
                PersonDL.removePerson(index);
                PersonDL.saveData();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Booking Canceled");
                Console.ForegroundColor = ConsoleColor.White;
            }
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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter Old Password: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string password = Console.ReadLine();
                bool valid1 = Validation.password_check(password);
                if (valid1 == true)
                {
                    index = UserDL.foundUser(password);
                    if (index != -1)
                    {
                        isFound = true;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Enter New Password: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        string newPassword1 = Console.ReadLine();
                        bool valid2 = Validation.password_check(newPassword1);
                        if (valid2 == true)
                        {
                            bool isSame = UserDL.isPassowrdSame(newPassword1);
                            if (isSame == false)
                            {
                                if (newPassword1 == password)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Same as old password");
                                    Console.WriteLine("Try Again");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Enter (y) to continue or (n) for back: ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    back = char.Parse(Console.ReadLine());
                                    if (back == 'y')
                                    {
                                        continue;
                                    }
                                    else if (back == 'n')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Interface.wrongInput();
                                        Interface.clear();
                                        break;
                                    }
                                }
                                else if (newPassword1 != password)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("Confirm New Password: ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
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
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Password Changed");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    UserDL.saveUserData();
                                    Interface.clear();
                                    break;
                                }
                                else if (newPassword2 != newPassword1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Password Not Match");
                                    Console.WriteLine("Try Again");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Enter (y) to continue or (n) for back: ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    back = char.Parse(Console.ReadLine());
                                    if (back == 'y')
                                    {
                                        continue;
                                    }
                                    else if (back == 'n')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Interface.wrongInput();
                                        Interface.clear();
                                        break;
                                    }
                                }
                            }
                            else if (isSame == true)
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
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Password Not Match");
                            Console.WriteLine("Try Again");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Enter (y) to continue or (n) for back: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            back = char.Parse(Console.ReadLine());
                            if (back == 'y')
                            {
                                continue;
                            }
                            else if (back == 'n')
                            {
                                break;
                            }
                            else
                            {
                                Interface.wrongInput();
                                Interface.clear();
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

        // Give Review
        public static void giveReview()
        {
            int index = customerIndex();
            if (index == -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Customer Not Found");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (index != -2)
            {
                Console.WriteLine();
                PersonDL.customerReview(index);
                PersonDL.saveData();
            }
        }

        // Give Rating
        public static void giveRating()
        {
            int index = customerIndex();
            if (index == -1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Customer Not Found");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (index != -2)
            {
                Console.WriteLine();
                ratingMenu();
                PersonDL.customerRating(index);
                PersonDL.saveData();
            }
        }
    }
}

