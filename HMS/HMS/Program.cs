using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HMS
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Sign Up Users
            const int totalUser = 100;
            int userCount = 0;
            string[] usersName = new string[totalUser];
            string[] passwords = new string[totalUser];
            string[] roles = new string[totalUser];

            // To Add Customers
            const int totalRoom = 200;
            int customerCount = 0;
            const int totalReview = 200;
            int reviewCount = 0;
            int ratingCount = 0;
            int roomCount = 1;
            string[] customer = new string[totalRoom];
            string[] id = new string[totalRoom];
            string[] contact = new string[totalRoom];
            string[] city = new string[totalRoom];
            string[] totalPerson = new string[totalRoom];
            string[] roomType = new string[totalRoom];
            int[] roomNumber = new int[totalRoom];
            string[] no_of_stay = new string[totalRoom];
            string[] checkIn = new string[totalRoom];
            string[] review = new string[totalReview];
            string[] rating = new string[totalReview];

            // Room Prices
            int type_single = 3000;
            int type_double = 5000;
            int type_triple = 8000;
            int type_twin = 6000;
            int type_executive = 15000;
            int type_king = 10000;

            string role;
            bool exit_app = false;
            string option;

            string usersPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP\\HMS\\Users.txt";
            string customersPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP\\HMS\\Customers.txt";

            loadUserData(usersPath, usersName, passwords, roles, ref userCount);
            loadCustomerData(customersPath, customer, id, contact, city, totalPerson, roomType, no_of_stay, checkIn, roomNumber, ref customerCount, ref roomCount);
            

            do
            {
                printHeader();
                loginSignup();
                option = choice();
                if (option == "1")
                {
                here:
                    printHeader();
                    mainSubMenu("SignUp");
                    Console.Write("Enter User Name: ");
                    string name = Console.ReadLine();
                    bool valid_name = userName_check(name);
                    if (valid_name == true)
                    {
                        Console.Write("Enter Password: ");
                        string password = Console.ReadLine();
                        bool valid = password_check(password);
                        if (valid == true)
                        {
                            bool signUpCheck = isValidUsername(name, userCount, usersName);
                            if (signUpCheck == true)
                            {
                                signUp(usersName, passwords, roles, name, password, ref userCount);
                                saveUserData(usersPath, usersName, passwords, userCount);
                                Console.WriteLine("Sign Up Successfully");
                            }
                            else if (signUpCheck == false)
                            {
                                Console.WriteLine("Username Already Exist");
                                clear();
                                goto here;
                            }
                        }
                        else if (valid == false)
                        {
                            Console.WriteLine("Password must be 8 characters long (Mix of numbers,letters and special characters(#,$,%,&)");
                            clear();
                            goto here;
                        }
                    }
                    else if (valid_name == false)
                    {
                        Console.WriteLine("Username must be 7 characters long (Only use Alphabets and Underscore)");
                        clear();
                        goto here;
                    }
                    clear();
                    continue;
                }
                else if (option == "2")
                {
                    printHeader();
                    mainSubMenu("Login");
                    Console.Write("Enter User Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    role = login(usersName, passwords, roles, userCount, name, password);
                    if (role == "manager")
                    {
                        string option_manager;
                        while (true)
                        {
                            printHeader();
                            managerMenu();
                            option_manager = choice();
                            if (option_manager == "1")
                            {
                            there:
                                printHeader();
                                subMenu("Add Customer");
                                if (customerCount < totalRoom)
                                {
                                    Console.Write("Enter Name: ");
                                    string customerName = Console.ReadLine();
                                    bool valid = isValid(customerName);
                                    if (valid == true)
                                    {
                                        Console.Write("Enter CNIC: ");
                                        string customerId = Console.ReadLine();
                                        bool valid_id = id_check(customerId);
                                        if (valid_id == true)
                                        {
                                            bool isCheck = checkCustomer(id, customerCount, customerId);
                                            if (isCheck == true)
                                            {
                                                Console.Write("Enter Contact: ");
                                                string customerContact = Console.ReadLine();
                                                bool valid_contact = contact_check(customerContact);
                                                if (valid_contact == true)
                                                {
                                                    Console.Write("Enter City: ");
                                                    string customerCity = Console.ReadLine();
                                                    bool valid_city = isValid(customerCity);
                                                    if (valid_city == true)
                                                    {
                                                        Console.Write("Enter Number of Person(1 - 5): ");
                                                        string customerTotalPerson = (Console.ReadLine());
                                                        bool valid_totalPerson = check_person(customerTotalPerson);
                                                        if (valid_totalPerson == true)
                                                        {
                                                            roomSuggestion(customerTotalPerson);
                                                            Console.Write("Enter Room Type: ");
                                                            string customerRoomType = Console.ReadLine();
                                                            bool valid_roomType = check_room_type(customerRoomType);
                                                            if (valid_roomType == true)
                                                            {
                                                                Console.Write("Enter No. of Stay: ");
                                                                string stay_days = (Console.ReadLine());
                                                                bool valid_stay = check_stay(stay_days);
                                                                if (valid_stay == true)
                                                                {
                                                                    Console.Write("Enter CheckIn Date (DD/MM/YYYY): ");
                                                                    string date = Console.ReadLine();
                                                                    bool valid_date = date_check(date);
                                                                    if (valid_date == true)
                                                                    {
                                                                        addNewCustomer(customer, id, contact, city, totalPerson, roomType, no_of_stay, checkIn, roomNumber, ref roomCount, ref customerCount, customerName, customerId, customerContact, customerCity, customerTotalPerson, customerRoomType, stay_days, date);
                                                                        saveCustomerData(customersPath, customer, id, contact, city, totalPerson, roomType, no_of_stay, checkIn, roomNumber, customerCount);
                                                                        Console.WriteLine("Customer Added");
                                                                    }
                                                                    else if (valid_date == false)
                                                                    {
                                                                        Console.WriteLine("Enter a Valid Date");
                                                                        clear();
                                                                        goto there;
                                                                    }
                                                                }
                                                                else if (valid_stay == false)
                                                                {
                                                                    Console.WriteLine("Wrong Input\nTry Again");
                                                                    clear();
                                                                    goto there;
                                                                }
                                                            }
                                                            else if (valid_roomType == false)
                                                            {
                                                                Console.WriteLine("Wrong Input\nTry Again");
                                                                clear();
                                                                goto there;
                                                            }
                                                        }
                                                        else if (valid_totalPerson == false)
                                                        {
                                                            Console.WriteLine("Wrong Input\nTry Again");
                                                            clear();
                                                            goto there;
                                                        }
                                                    }
                                                    else if (valid_city == false)
                                                    {
                                                        Console.WriteLine("Wrong Input\nTry Again");
                                                        clear();
                                                        goto there;
                                                    }
                                                }
                                                else if (valid_contact == false)
                                                {
                                                    Console.WriteLine("Enter a Valid Number");
                                                    clear();
                                                    goto there;
                                                }
                                            }
                                            else if (isCheck == false)
                                            {
                                                Console.WriteLine("Already Exist");
                                            }
                                        }
                                        else if (valid_id == false)
                                        {
                                            Console.WriteLine("Please Enter Valid Format (#####-#######-#)");
                                            clear();
                                            goto there;
                                        }
                                    }
                                    else if (valid == false)
                                    {
                                        Console.WriteLine("Enter a Valid Name");
                                        clear();
                                        goto there;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No Free Room");
                                }
                                clear();
                            }
                            else if (option_manager == "2")
                            {
                                printHeader();
                                subMenu("Update Customer");
                                updateCustomer(customer, id, totalPerson, roomType, no_of_stay, customerCount, customersPath, contact, city, checkIn, roomNumber);
                                clear();
                            }
                            else if (option_manager == "3")
                            {
                                printHeader();
                                subMenu("Search Customer");
                                Console.Write("Enter Customer Name: ");
                                string customerName = Console.ReadLine();
                                bool valid = isValid(customerName);
                                if (valid == true)
                                {
                                    Console.Write("Enter Customer CNIC: ");
                                    string customerId = Console.ReadLine();
                                    bool id_valid = id_check(customerId);
                                    if (id_valid == true)
                                    {
                                        int isFound = foundCustomer(customer, id, customerName, customerId, customerCount);
                                        if (isFound == -1)
                                        {
                                            Console.WriteLine("Customer is not staying in this hotel");
                                        }
                                        else
                                        {
                                            searchCustomer(isFound, customer, roomNumber, roomType, totalPerson, no_of_stay, id, city, contact, checkIn);
                                        }
                                    }
                                    else if (id_valid == false)
                                    {
                                        Console.WriteLine("Please Enter Valid Format (#####-#######-#)");
                                    }
                                }
                                else if (valid == false)
                                {
                                    Console.WriteLine("Enter a Valid Name");
                                }
                                clear();
                            }
                            else if (option_manager == "4")
                            {
                                printHeader();
                                subMenu("Remove Customer");
                                Console.Write("Enter Customer Name: ");
                                string customerName = Console.ReadLine();
                                bool valid = isValid(customerName);
                                if (valid == true)
                                {
                                    Console.Write("Enter Customer CNIC: ");
                                    string customerId = Console.ReadLine();
                                    bool id_valid = id_check(customerId);
                                    if (id_valid == true)
                                    {
                                        int isFound = foundCustomer(customer, id, customerName, customerId, customerCount);
                                        if (isFound == -1)
                                        {
                                            Console.WriteLine("Customer Not Found");
                                        }
                                        else
                                        {
                                            removeCustomer(isFound, customer, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn, ref customerCount);
                                            saveCustomerData(customersPath, customer, id, contact, city, totalPerson, roomType, no_of_stay, checkIn, roomNumber, customerCount);
                                            Console.WriteLine("Customer Removed");
                                        }
                                    }
                                    else if (id_valid == false)
                                    {
                                        Console.WriteLine("Please Enter Valid Format (#####-#######-#)");
                                    }
                                }
                                else if (valid == false)
                                {
                                    Console.WriteLine("Enter a Valid Name");
                                }
                                clear();
                            }
                            else if (option_manager == "5")
                            {
                                printHeader();
                                subMenu("View Booked Rooms");
                                bookedRooms(customer, roomNumber, totalPerson, no_of_stay, contact, checkIn, roomType, customerCount);
                                clear();
                            }
                            else if (option_manager == "6")
                            {
                                printHeader();
                                subMenu("View Available Rooms");
                                int rooms = availableRooms(totalRoom, customerCount);
                                Console.WriteLine("Total Rooms: " + totalRoom);
                                Console.WriteLine("No. of Available Rooms: " + rooms);
                                clear();
                            }
                            else if (option_manager == "7")
                            {
                                printHeader();
                                subMenu("View Room Categories");
                                roomCategories(type_single, type_double, type_triple, type_twin, type_executive, type_king);
                                clear();
                            }
                            else if (option_manager == "8")
                            {
                                printHeader();
                                subMenu("Checkout");
                                Console.Write("Enter Customer Name: ");
                                string customerName = Console.ReadLine();
                                bool valid = isValid(customerName);
                                if (valid == true)
                                {
                                    Console.Write("Enter Customer CNIC: ");
                                    string customerId = Console.ReadLine();
                                    bool id_valid = id_check(customerId);
                                    if (id_valid == true)
                                    {
                                        int isFound = foundCustomer(customer, id, customerName, customerId, customerCount);
                                        if (isFound == -1)
                                        {
                                            Console.WriteLine("Customer is not staying in this hotel");
                                        }
                                        else
                                        {
                                            printHeader();
                                            subMenu("Checkout");
                                            int bill = checkoutBill(isFound, roomType, type_single, type_double, type_triple, type_twin, type_executive, type_king, no_of_stay);
                                            checkout(isFound, customer, roomNumber, roomType, totalPerson, no_of_stay, id, city, contact, checkIn);
                                            Console.WriteLine("Total Bill: " + bill);
                                            removeCustomer(isFound, customer, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn, ref customerCount);
                                            saveCustomerData(customersPath, customer, id, contact, city, totalPerson, roomType, no_of_stay, checkIn, roomNumber, customerCount);
                                            Console.WriteLine("Thank You!");
                                        }
                                    }
                                    else if (id_valid == false)
                                    {
                                        Console.WriteLine("Please Enter Valid Format (#####-#######-#)");
                                    }
                                }
                                else if (valid == false)
                                {
                                    Console.WriteLine("Enter a Valid Name");
                                }
                                clear();
                            }
                            else if (option_manager == "9")
                            {
                                printHeader();
                                subMenu("View Reviews");
                                viewReviews(reviewCount, review);
                                clear();
                            }
                            else if (option_manager == "10")
                            {
                                printHeader();
                                subMenu("View Ratings");
                                viewRatings(ratingCount, rating);
                                clear();
                            }
                            else if (option_manager == "11")
                            {
                                break;
                            }
                            else if (option_manager == "12")
                            {
                                exit_app = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong input\nTry again");
                                clear();
                            }
                        }
                        if (exit_app == true)
                        {
                            break;
                        }
                    }
                    else if (role == "customer")
                    {
                        Console.WriteLine("Customer");
                        Console.ReadKey();
                        if (exit_app == true)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials");
                        clear();
                    }
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input\nTry again");
                    clear();
                }
            }
            while (option != "3");


        }
        static void printHeader()
        {
            Console.Clear();
            Console.WriteLine(" __   __  _______  _______  _______  ___        __   __  _______  __    _  _______  _______  _______  __   __  _______  __    _  _______    _______  __   __  _______  _______  _______  __   __   ");
            Console.WriteLine("|  | |  ||       ||       ||       ||   |      |  |_|  ||   _   ||  |  | ||   _   ||       ||       ||  |_|  ||       ||  |  | ||       |  |       ||  | |  ||       ||       ||       ||  |_|  |  ");
            Console.WriteLine("|  |_|  ||   _   ||_     _||    ___||   |      |       ||  |_|  ||   |_| ||  |_|  ||    ___||    ___||       ||    ___||   |_| ||_     _|  |  _____||  |_|  ||  _____||_     _||    ___||       |  ");
            Console.WriteLine("|       ||  | |  |  |   |  |   |___ |   |      |       ||       ||       ||       ||   | __ |   |___ |       ||   |___ |       |  |   |    | |_____ |       || |_____   |   |  |   |___ |       |  ");
            Console.WriteLine("|       ||  |_|  |  |   |  |    ___||   |___   |       ||       ||  _    ||       ||   ||  ||    ___||       ||    ___||  _    |  |   |    |_____  ||_     _||_____  |  |   |  |    ___||       |  ");
            Console.WriteLine("|   _   ||       |  |   |  |   |___ |       |  | ||_|| ||   _   || | |   ||   _   ||   |_| ||   |___ | ||_|| ||   |___ | | |   |  |   |     _____| |  |   |   _____| |  |   |  |   |___ | ||_|| |  ");
            Console.WriteLine("|__| |__||_______|  |___|  |_______||_______|  |_|   |_||__| |__||_|  |__||__| |__||_______||_______||_|   |_||_______||_|  |__|  |___|    |_______|  |___|  |_______|  |___|  |_______||_|   |_|  ");
            Console.WriteLine();
        }
        static string choice()
        {
            string option;
            Console.Write("Enter Your Choice: ");
            option = Console.ReadLine();
            return option;
        }
        static void clear()
        {
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
        static void subMenu(string subMenu)
        {
            string message = "Main Menu > " + subMenu;
            Console.WriteLine(message);
            Console.WriteLine("--------------------------------------------");
        }
        static void mainSubMenu(string mainSubMenu)
        {
            string message = "Login and Sign-Up Menu > " + mainSubMenu;
            Console.WriteLine(message);
            Console.WriteLine("--------------------------------------------");
        }

        // Separating credentials for storing in arrays individually
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        // Validations
        static bool password_check(string password)
        {
            bool flag = false;
            int i = 0;
            while (i < password.Length)
            {\\\\\\\\\\\
            
                if ((password[i] > 63 && password[i] < 91) || (password[i] > 96 && password[i] < 123) || (password[i] > 47 && password[i] < 58) || (password[i] > 34 && password[i] < 39))
                {
                    i++;
                    if (i >= 8 && i <= 100)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static bool userName_check(string name)
        {
            bool flag = false;
            int i = 0;
            while (i < name.Length)
            {
                if ((name[i] > 64 && name[i] < 91) || (name[i] > 96 && name[i] < 123) || (name[i] > 94 && name[i] < 96))
                {
                    i++;
                    if (i >= 7 && i <= 20)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        static bool isValid(string check)
        {
            bool flag = false;
            int i = 0;
            while (i < check.Length)
            {
                if ((check[i] > 64 && check[i] < 91) || (check[i] > 96 && check[i] < 123) || (check[i] > 31 && check[i] < 33))
                {
                    i++;
                    if (i >= 3)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        static bool id_check(string id)
        {
            bool flag = false;
            int x = 0;
            while (x < id.Length)
            {
                if (x < 5)
                {
                    if (id[x] > 47 && id[x] < 58)
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 4 && x < 6)
                {
                    if (id[5] == '-')
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 5 && x < 13)
                {
                    if ((id[x] > 47 && id[x] < 58))
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 12 && x < 14)
                {
                    if (id[13] == '-')
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 13 && x < 15)
                {
                    if ((id[x] > 47 && id[x] < 58))
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static bool check_person(string totalPerson)
        {
            bool flag = false;
            if (totalPerson == "1" || totalPerson == "2" || totalPerson == "3" || totalPerson == "4" || totalPerson == "5")
            {
                flag = true;
            }
            return flag;
        }
        static bool contact_check(string contact)
        {
            bool flag = false;
            int i = 0;
            while (i < contact.Length)
            {
                if (i == 0)
                {
                    if (contact[0] == '0')
                    {
                        i++;
                        if (i == 11)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (contact[i] > 47 && contact[i] < 58)
                {
                    i++;
                    if (i == 11)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static bool check_stay(string stay)
        {
            bool flag = false;
            if (stay == "1")
            {
                flag = true;
            }
            else if (stay == "2")
            {
                flag = true;
            }
            else if (stay == "3")
            {
                flag = true;
            }
            else if (stay == "4")
            {
                flag = true;
            }
            else if (stay == "5")
            {
                flag = true;
            }
            else if (stay == "6")
            {
                flag = true;
            }
            else if (stay == "7")
            {
                flag = true;
            }
            else if (stay == "8")
            {
                flag = true;
            }
            else if (stay == "9")
            {
                flag = true;
            }
            else if (stay == "10")
            {
                flag = true;
            }
            else if (stay == "11")
            {
                flag = true;
            }
            else if (stay == "12")
            {
                flag = true;
            }
            else if (stay == "13")
            {
                flag = true;
            }
            else if (stay == "14")
            {
                flag = true;
            }
            else if (stay == "15")
            {
                flag = true;
            }
            else if (stay == "16")
            {
                flag = true;
            }
            else if (stay == "17")
            {
                flag = true;
            }
            else if (stay == "18")
            {
                flag = true;
            }
            else if (stay == "19")
            {
                flag = true;
            }
            else if (stay == "20")
            {
                flag = true;
            }
            else if (stay == "21")
            {
                flag = true;
            }
            else if (stay == "22")
            {
                flag = true;
            }
            else if (stay == "23")
            {
                flag = true;
            }
            else if (stay == "24")
            {
                flag = true;
            }
            else if (stay == "25")
            {
                flag = true;
            }
            else if (stay == "26")
            {
                flag = true;
            }
            else if (stay == "27")
            {
                flag = true;
            }
            else if (stay == "28")
            {
                flag = true;
            }
            else if (stay == "29")
            {
                flag = true;
            }
            else if (stay == "30")
            {
                flag = true;
            }
            else if (stay == "31")
            {
                flag = true;
            }
            return flag;
        }
        static bool check_room_type(string room)
        {
            bool flag = false;
            if (room == "Single" || room == "single")
            {
                flag = true;
            }
            else if (room == "Double" || room == "double")
            {
                flag = true;
            }
            else if (room == "Triple" || room == "triple")
            {
                flag = true;
            }
            else if (room == "Twin" || room == "twin")
            {
                flag = true;
            }
            else if (room == "Executive" || room == "executive")
            {
                flag = true;
            }
            else if (room == "King" || room == "king")
            {
                flag = true;
            }
            return flag;
        }
        static bool date_check(string date)
        {
            bool flag = false;
            int x = 0;
            while (x < date.Length)
            {
                if (x == 0)
                {
                    if (date[x] > 47 && date[x] < 52)
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 1)
                {
                    if (date[0] == '0')
                    {
                        if (date[x] > 48 && date[x] < 58)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (date[0] == '1' || date[0] == '2')
                    {
                        if (date[x] > 47 && date[x] < 58)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (date[0] == '3')
                    {
                        if (date[x] > 47 && date[x] < 50)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 2)
                {
                    if (date[2] == '/')
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 3)
                {
                    if (date[x] > 47 && date[x] < 50)
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 4)
                {
                    if (date[3] == '0')
                    {
                        if (date[x] > 48 && date[x] < 58)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (date[3] == '1')
                    {
                        if (date[x] > 48 && date[x] < 51)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (x == 5)
                {
                    if (date[5] == '/')
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x > 5 && x < 10)
                {
                    if (date[x] > 47 && date[x] < 58)
                    {
                        x++;
                        if (x == 10)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }


        // --------------------------------------------------SignUp & Login Functionality------------------------------------------------------------------------------
        static void loginSignup()
        {
            Console.WriteLine("Login and Sign-Up Menu >");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select one of the following options number...");
            Console.WriteLine("1- Sign-Up");
            Console.WriteLine("2- Login");
            Console.WriteLine("3- Exit");
        }
        static bool isValidUsername(string name, int userCount, string[] usersName)
        {
            bool isNew = true;
            for (int index = 0; index < userCount; index++)
            {
                if (usersName[index] == name)
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }
        static void signUp(string[] usersName, string[] passwords, string[] roles, string name, string password, ref int userCount)
        {
            usersName[userCount] = name;
            passwords[userCount] = password;
            roles[userCount] = "customer";
            userCount++;
        }
        static string login(string[] usersName, string[] passwords, string[] roles, int userCount, string name, string password)
        {
            string role = "undefined";
            for (int index = 0; index < userCount; index++)
            {
                if (usersName[index] == name && passwords[index] == password)
                {
                    role = roles[index];
                    break;
                }
            }
            return role;
        }

        // Store User Data in File
        static void saveUserData(string usersPath, string[] names, string[] password, int userCount)
        {
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int x = 0; x < userCount; x++)
            {
                file.Write(names[x] + "," + password[x] + ",");
                if (x == 0)
                {
                    file.WriteLine("manager");
                }
                else
                {
                    file.WriteLine("customer");
                }
            }
            file.Flush();
            file.Close();
        }

        // Reading User File for Storing Data in Arrays
        static void loadUserData(string usersPath, string[] usersName, string[] passwords, string[] roles, ref int userCount)
        {
            StreamReader file = new StreamReader(usersPath);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                usersName[userCount] = parseData(record, 1);
                passwords[userCount] = parseData(record, 2);
                roles[userCount] = parseData(record, 3);
                userCount = userCount + 1;
            }
            file.Close();
        }

        // Store Customer Data in File
        static void saveCustomerData(string customersPath, string[] customer, string[] id, string[] contact, string[] city, string[] totalPerson, string[] roomType, string[] no_of_stay, string[] checkIn, int[] roomNumber, int customerCount)
        {
            StreamWriter file = new StreamWriter(customersPath, false);
            for (int i = 0; i < customerCount; i++)
            {
                file.WriteLine(customer[i] + "," + id[i] + "," + contact[i] + "," + city[i] + "," + totalPerson[i] + "," + roomType[i] + "," + no_of_stay[i] + "," + checkIn[i] + "," + roomNumber[i]);
            }
            file.Flush();
            file.Close();
        }

        // Reading Customer File for Storing Data in Arrays
        static void loadCustomerData(string customersPath, string[] customer, string[] id, string[] contact, string[] city, string[] totalPerson, string[] roomType, string[] no_of_stay, string[] checkIn, int[] roomNumber, ref int customerCount, ref int roomCount)
        {
            StreamReader file = new StreamReader(customersPath);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                customer[customerCount] = parseData(record, 1);
                id[customerCount] = parseData(record, 2);
                contact[customerCount] = parseData(record, 3);
                city[customerCount] = parseData(record, 4);
                totalPerson[customerCount] = (parseData(record, 5));
                roomType[customerCount] = parseData(record, 6);
                no_of_stay[customerCount] = (parseData(record, 7));
                checkIn[customerCount] = parseData(record, 8);
                roomNumber[customerCount] = int.Parse(parseData(record, 9));
                customerCount = customerCount + 1;
                roomCount++;
            }
            file.Close();
        }


        // ---------------------------------------------------------Manager Functionality--------------------------------------------------------------------------------------
        static void managerMenu()
        {
            Console.WriteLine("Main Menu >");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select one of the following options number...");
            Console.WriteLine("1- Add Customer");
            Console.WriteLine("2- Update Customer");
            Console.WriteLine("3- Search Customer");
            Console.WriteLine("4- Remove Customer");
            Console.WriteLine("5- View Booked Rooms");
            Console.WriteLine("6- View Available Rooms");
            Console.WriteLine("7- View Room Categories");
            Console.WriteLine("8- Checkout");
            Console.WriteLine("9- View Reviews");
            Console.WriteLine("10- View Ratings");
            Console.WriteLine("11- Logout");
            Console.WriteLine("12- Exit");
        }

        // Add Customer
        static bool checkCustomer(string[] id, int customerCount, string customerId)
        {
            bool isNew = true;
            for (int index = 0; index < customerCount; index++)
            {
                if (id[index] == customerId)
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }
        static int foundCustomer(string[] customer, string[] id, string customerName, string customerId, int customerCount)
        {
            int indexFound = -1;
            for (int index = 0; index < customerCount; index++)
            {
                if (customer[index] == customerName && id[index] == customerId)
                {
                    indexFound = index;
                    break;
                }
            }
            return indexFound;
        }
        static void addNewCustomer(string[] customer, string[] id, string[] contact, string[] city, string[] totalPerson, string[] roomType, string[] no_of_stay, string[] checkIn, int[] roomNumber, ref int roomCount, ref int customerCount, string customerName, string customerId, string customerContact, string customerCity, string customerTotalPerson, string customerRoomType, string stay_days, string date)
        {
            customer[customerCount] = customerName;
            id[customerCount] = customerId;
            contact[customerCount] = customerContact;
            city[customerCount] = customerCity;
            totalPerson[customerCount] = customerTotalPerson;
            roomType[customerCount] = customerRoomType;
            no_of_stay[customerCount] = stay_days;
            checkIn[customerCount] = date;
            roomNumber[customerCount] = roomCount;
            roomCount++;
            customerCount++;
        }

        // Update Customer
        static void updateCustomer(string[] customer, string[] id, string[] totalPerson, string[] roomType, string[] no_of_stay, int customerCount, string customersPath, string[] contact, string[] city, string[] checkIn, int[] roomNumber)
        {
            string option_update;
            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();
            bool valid = isValid(customerName);
            if (valid == true)
            {
                Console.Write("Enter Customer CNIC: ");
                string customerId = Console.ReadLine();
                bool id_valid = id_check(customerId);
                if (id_valid == true)
                {
                    int isFound = foundCustomer(customer, id, customerName, customerId, customerCount);
                    if (isFound == -1)
                    {
                        Console.WriteLine("Customer Not Found");
                    }
                    else
                    {
                        while (true)
                        {
                            printHeader();
                            subMenu("Update Customer");
                            updateMenu();
                            option_update = choice();
                            if (option_update == "1")
                            {
                                Console.Write("Enter Customer Name: ");
                                string name = Console.ReadLine();
                                bool valid_name = isValid(name);
                                if (valid_name == true)
                                {
                                    updateName(customer, name, isFound);
                                }
                                else if(valid_name == false)
                                {
                                    Console.WriteLine("Enter a Valid Name");
                                    clear();
                                }
                            }
                            else if (option_update == "2")
                            {
                                Console.Write("Enter Number of Person(1 - 5): ");
                                string customerTotalPerson = Console.ReadLine();
                                bool valid_totalPerson = check_person(customerTotalPerson);
                                if (valid_totalPerson == true)
                                {
                                    updateTotalPerson(totalPerson, customerTotalPerson, isFound);
                                }
                                else if(valid_totalPerson == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    clear();
                                }
                            }
                            else if (option_update == "3")
                            {
                                Console.Write("Enter Room Type: ");
                                string customerRoomType = Console.ReadLine();
                                bool valid_roomType = check_room_type(customerRoomType);
                                if (valid_roomType == true)
                                {
                                    updateRoomType(roomType, customerRoomType, isFound);
                                }
                                else if(valid_roomType == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    clear();
                                }
                            }
                            else if (option_update == "4")
                            {
                                Console.Write("Enter No. of Stay: ");
                                string stay_days = Console.ReadLine();
                                bool valid_stay = check_stay(stay_days);
                                if (valid_stay == true)
                                {
                                    updateStayDay(no_of_stay, stay_days, isFound);
                                }
                                else if(valid_stay == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    clear();
                                }
                            }
                            else if (option_update == "5")
                            {
                                saveCustomerData(customersPath, customer, id, contact, city, totalPerson, roomType, no_of_stay, checkIn, roomNumber, customerCount);
                                Console.WriteLine("Successfully Saved");
                                break;
                            }
                        }
                    }
                }
                else if (id_valid == false)
                {
                    Console.WriteLine("Please Enter Valid Format (#####-#######-#)");
                }
            }
            else if (valid == false)
            {
                Console.WriteLine("Enter a Valid Name");
            }
        }
        static void updateMenu()
        {
            Console.WriteLine("Select option to make changes....");
            Console.WriteLine("1- Customer Name");
            Console.WriteLine("2- Number of Person");
            Console.WriteLine("3- Room Type");
            Console.WriteLine("4- Number of Stay");
            Console.WriteLine("5- Save Changes");
            Console.WriteLine();
        }
        static void updateName(string[] customer, string name, int index)
        {
            customer[index] = name;
        }
        static void updateTotalPerson(string[] totalPerson, string personCount, int index)
        {
            totalPerson[index] = personCount;
        }
        static void updateRoomType(string[] roomType, string roomCategory, int index)
        {
            roomType[index] = roomCategory;
        }
        static void updateStayDay(string[] no_of_stay, string stay, int index)
        {
            no_of_stay[index] = stay;
        }

        // Search Customer
        static void searchCustomer(int index, string[] customer, int[] roomNumber, string[] roomType, string[] totalPerson, string[] no_of_stay, string[] id, string[] city, string[] contact, string[] checkIn)
        {
            printHeader();
            subMenu("Search Customer");
            Console.WriteLine("Customer Name: " + customer[index]);
            Console.WriteLine("Room Number: " + roomNumber[index]);
            Console.WriteLine("Room Type: " + roomType[index]);
            Console.WriteLine("Number of Person: " + totalPerson[index]);
            Console.WriteLine("No. of Stay: " + no_of_stay[index]);
            Console.WriteLine("CNIC: " + id[index]);
            Console.WriteLine("City: " + city[index]);
            Console.WriteLine("Contact: " + contact[index]);
            Console.WriteLine("CheckIn Date: " + checkIn[index]);
        }

        // Remove Customer
        static void removeCustomer(int index, string[] customer, string[] id, string[] contact, string[] city, string[] totalPerson, string[] roomType, int[] roomNumber, string[] no_of_stay, string[] checkIn, ref int customerCount)
        {
            customer[index] = " ";
            for (int x = 0; x < customerCount; x++)
            {
                if (customer[x] == " ")
                {
                    customer[x] = customer[x + 1];
                    id[x] = id[x + 1];
                    contact[x] = contact[x + 1];
                    city[x] = city[x + 1];
                    totalPerson[x] = totalPerson[x + 1];
                    roomType[x] = roomType[x + 1];
                    roomNumber[x] = roomNumber[x + 1];
                    no_of_stay[x] = no_of_stay[x + 1];
                    checkIn[x] = checkIn[x + 1];
                    customer[x + 1] = " ";
                }
            }
            customerCount--;
        }

        // View Booked Rooms
        static void bookedRooms(string[] customer, int[] roomNumber, string[] totalPerson, string[] no_of_stay, string[] contact, string[] checkIn, string[] roomType, int customerCount)
        {
            Console.WriteLine("Customer Name" + "\t\t\t" + "Room Number" + "\t" + "No. of Person" + "\t" + "No. of Stay" + "\t" + "Contact" + "\t\t" + "CheckIn Date" + "\t" + "Room Type");
            for (int index = 0; index < customerCount; index++)
            {
                Console.WriteLine(customer[index] + "\t\t\t\t" + roomNumber[index] + "\t\t" + totalPerson[index] + "\t\t" + no_of_stay[index] + "\t\t" + contact[index] + "\t" + checkIn[index] + "\t" + roomType[index]);
            }
        }

        // View Available Rooms
        static int availableRooms(int totalRoom, int customerCount)
        {
            int freeRooms;
            freeRooms = totalRoom - customerCount;
            return freeRooms;
        }

        // Room Categories
        static void roomCategories(int type_single, int type_double, int type_triple, int type_twin, int type_executive, int type_king)
        {
            Console.WriteLine("\t" + "Room Categories & their Facilities");
            Console.WriteLine();
            Console.WriteLine("1- Single: A room assigned to one person that consist of single bed.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_single);
            Console.WriteLine();
            Console.WriteLine("2- Double: A room assigned to two people. May have one or more beds.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_double);
            Console.WriteLine();
            Console.WriteLine("3- Triple: A room that can accommodate three persons and has been fitted with three twin beds.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_triple);
            Console.WriteLine();
            Console.WriteLine("4- Twin: A room with two twin beds. May be occupied by one or more people.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_twin);
            Console.WriteLine();
            Console.WriteLine("5- Executive: A parlour or living room connected with to one or more bedrooms.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_executive);
            Console.WriteLine();
            Console.WriteLine("6- King: A room with a king-sized bed. May be occupied by one or more people.");
            Console.WriteLine("\t" + "* Price Per Night: " + type_king);
            Console.WriteLine();
        }
        static void roomSuggestion(string total_person)
        {
            if (total_person == "1")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Single");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("---------------------");
            }
            else if (total_person == "2")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Double");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
            else if (total_person == "3")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Triple");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
            else if (total_person == "4" || total_person == "5")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
        }

        // Checkout
        static void checkout(int index, string[] customer, int[] roomNumber, string[] roomType, string[] totalPerson, string[] no_of_stay, string[] id, string[] city, string[] contact, string[] checkIn)
        {
            Console.WriteLine("Customer Name: " + customer[index]);
            Console.WriteLine("Room Number: " + roomNumber[index]);
            Console.WriteLine("Room Type: " + roomType[index]);
            Console.WriteLine("Number of Person: " + totalPerson[index]);
            Console.WriteLine("No. of Stay: " + no_of_stay[index]);
            Console.WriteLine("CNIC: " + id[index]);
            Console.WriteLine("City: " + city[index]);
            Console.WriteLine("Contact: " + contact[index]);
            Console.WriteLine("CheckIn Date: " + checkIn[index]);
        }
        static int checkoutBill(int index, string[] roomType, int type_single, int type_double, int type_triple, int type_twin, int type_executive, int type_king, string[] no_of_stay)
        {
            int bill = 0;
            int stay_days = int.Parse(no_of_stay[index]);
            if (roomType[index] == "single" || roomType[index] == "Single")
            {
                bill = type_single * stay_days;
            }
            else if (roomType[index] == "double" || roomType[index] == "Double")
            {
                bill = type_double * stay_days;
            }
            else if (roomType[index] == "triple" || roomType[index] == "Triple")
            {
                bill = type_triple * stay_days;
            }
            else if (roomType[index] == "twin" || roomType[index] == "Twin")
            {
                bill = type_twin * stay_days;
            }
            else if (roomType[index] == "executive" || roomType[index] == "Executive")
            {
                bill = type_executive * stay_days;
            }
            else if (roomType[index] == "king" || roomType[index] == "King")
            {
                bill = type_king * stay_days;
            }
            return bill;
        }

        // Reviews
        static void viewReviews(int reviewCount, string[] review)
        {
            if (reviewCount == 0)
            {
                Console.WriteLine("No Reviews");
            }
            else
            {
                for (int index = 0; index < reviewCount; index++)
                {
                    Console.WriteLine("> " + review[index]);
                }
            }
        }

        // Ratings
        static void viewRatings(int ratingCount, string[] rating)
        {
            if (ratingCount == 0)
            {
                Console.WriteLine("No Ratings");
            }
            else
            {
                for (int index = 0; index < ratingCount; index++)
                {
                    Console.WriteLine("> " + rating[index]);
                }
            }
        }
    }
}
