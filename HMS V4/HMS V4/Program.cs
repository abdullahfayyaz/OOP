using HMS_V4.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<user> userData = new List<user>();
            List<customer> customerData = new List<customer>();
            List<feedback> review = new List<feedback>();
            List<feedback> rating = new List<feedback>();

            const int totalRoom = 200;
            int roomCount = 1;

            string role = "";
            bool exit_app = false;
            string option;

            string usersPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\HMS V4\\Users.txt";
            string customersPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\HMS V4\\Customers.txt";

            loadUserData(usersPath, userData);
            loadCustomerData(customersPath, customerData, ref roomCount);


            do
            {
                printHeader();
                loginSignup();
                option = choice();
                if (option == "1")
                {
                    signUp(userData, usersPath);
                }
                else if (option == "2")
                {
                here:
                    printHeader();
                    mainSubMenu("Login");
                    user u = new user("abd", "123");
                    Console.Write("Enter User Name: ");
                    u.userName = Console.ReadLine();
                    bool valid_name = userName_check(u.userName);
                    if (valid_name == true)
                    {
                        Console.Write("Enter Password: ");
                        u.password = Console.ReadLine();
                        bool valid = password_check(u.password);
                        if (valid == true)
                        {
                            role = u.login(userData);
                            if (role == "manager")
                            {
                                managerInterface(customerData, review, rating, customersPath, ref roomCount, totalRoom, ref exit_app);
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
            {
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
        static void signUp(List<user> userData, string usersPath)
        {
            user u = new user();
        here:
            printHeader();
            mainSubMenu("SignUp");
            Console.Write("Enter User Name: ");
            u.userName = Console.ReadLine();
            bool valid_name = userName_check(u.userName);
            if (valid_name == true)
            {
                Console.Write("Enter Password: ");
                u.password = Console.ReadLine();
                bool valid = password_check(u.password);
                if (valid == true)
                {
                    bool signUpCheck = u.isValidUsername(userData);
                    if (signUpCheck == true)
                    {
                        userData.Add(u);
                        saveUserData(usersPath, userData);
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
        }

        // Store User Data in File
        static void saveUserData(string usersPath, List<user> userData)
        {
            StreamWriter file = new StreamWriter(usersPath, false);
            for (int i = 0; i < userData.Count(); i++)
            {
                user info = new user();
                info = userData[i];
                file.Write(info.userName + "," + info.password + ",");
                if (i == 0)
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
        static void loadUserData(string usersPath, List<user> userData)
        {
            if (File.Exists(usersPath))
            {
                StreamReader fileVariable = new StreamReader(usersPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    user info = new user();
                    info.userName = parseData(record, 1);
                    info.password = parseData(record, 2);
                    info.role = parseData(record, 3);
                    userData.Add(info);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }

        // Store Customer Data in File
        static void saveCustomerData(string customersPath, List<customer> customerData)
        {
            StreamWriter file = new StreamWriter(customersPath, false);
            for (int i = 0; i < customerData.Count(); i++)
            {
                customer info = new customer();
                info = customerData[i];
                file.WriteLine(info.name + "," + info.id + "," + info.contact + "," + info.city + "," + info.totalPerson + "," + info.roomType + "," + info.no_of_stay + "," + info.checkIn + "," + info.roomNumber);
            }
            file.Flush();
            file.Close();
        }

        // Reading Customer File for Storing Data in Arrays
        static void loadCustomerData(string customersPath, List<customer> customerData, ref int roomCount)
        {
            if (File.Exists(customersPath))
            {
                StreamReader file = new StreamReader(customersPath);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    customer info = new customer();
                    info.name = parseData(record, 1);
                    info.id = parseData(record, 2);
                    info.contact = parseData(record, 3);
                    info.city = parseData(record, 4);
                    info.totalPerson = (parseData(record, 5));
                    info.roomType = parseData(record, 6);
                    info.no_of_stay = (parseData(record, 7));
                    info.checkIn = parseData(record, 8);
                    info.roomNumber = int.Parse(parseData(record, 9));
                    customerData.Add(info);
                    roomCount++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }


        // ---------------------------------------------------------Manager Functionality--------------------------------------------------------------------------------------
        static void managerInterface(List<customer> customerData, List<feedback> review, List<feedback> rating, string customersPath, ref int roomCount, int totalRoom, ref bool exit_app)
        {
            string option_manager = "";
            while (true)
            {
                printHeader();
                managerMenu();
                option_manager = choice();
                if (option_manager == "1")
                {
                    customer c = new customer();
                there:
                    printHeader();
                    subMenu("Add Customer");
                    Console.Write("Enter Name: ");
                    c.name = Console.ReadLine();
                    bool valid = isValid(c.name);
                    if (valid == true)
                    {
                        Console.Write("Enter CNIC: ");
                        c.id = Console.ReadLine();
                        bool valid_id = id_check(c.id);
                        if (valid_id == true)
                        {
                            bool isCheck = c.checkCustomer(customerData);
                            if (isCheck == true)
                            {
                                Console.Write("Enter Contact: ");
                                c.contact = Console.ReadLine();
                                bool valid_contact = contact_check(c.contact);
                                if (valid_contact == true)
                                {
                                    Console.Write("Enter City: ");
                                    c.city = Console.ReadLine();
                                    bool valid_city = isValid(c.city);
                                    if (valid_city == true)
                                    {
                                        Console.Write("Enter Number of Person(1 - 5): ");
                                        c.totalPerson = (Console.ReadLine());
                                        bool valid_totalPerson = check_person(c.totalPerson);
                                        if (valid_totalPerson == true)
                                        {
                                            c.roomSuggestion();
                                            Console.Write("Enter Room Type: ");
                                            c.roomType = Console.ReadLine();
                                            bool valid_roomType = check_room_type(c.roomType);
                                            if (valid_roomType == true)
                                            {
                                                Console.Write("Enter No. of Stay: ");
                                                c.no_of_stay = (Console.ReadLine());
                                                bool valid_stay = check_stay(c.no_of_stay);
                                                if (valid_stay == true)
                                                {
                                                    Console.Write("Enter CheckIn Date (DD/MM/YYYY): ");
                                                    c.checkIn = Console.ReadLine();
                                                    bool valid_date = date_check(c.checkIn);
                                                    if (valid_date == true)
                                                    {
                                                        c.roomNumber = roomCount;
                                                        addCustomer(customerData, c, ref roomCount);
                                                        saveCustomerData(customersPath, customerData);
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
                    clear();
                }
                else if (option_manager == "2")
                {
                    printHeader();
                    subMenu("Update Customer");
                    updateCustomer(customerData, customersPath);
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
                            int isFound = foundCustomer(customerData, customerName, customerId);
                            if (isFound == -1)
                            {
                                Console.WriteLine("Customer is not staying in this hotel");
                            }
                            else
                            {
                                searchCustomer(customerData, isFound);
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
                            int isFound = foundCustomer(customerData, customerName, customerId);
                            if (isFound == -1)
                            {
                                Console.WriteLine("Customer Not Found");
                            }
                            else
                            {
                                customerData.RemoveAt(isFound);
                                saveCustomerData(customersPath, customerData);
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
                    bookedRooms(customerData);
                    clear();
                }
                else if (option_manager == "6")
                {
                    printHeader();
                    subMenu("View Available Rooms");
                    int rooms = availableRooms(customerData, totalRoom);
                    Console.WriteLine("Total Rooms: " + totalRoom);
                    Console.WriteLine("No. of Available Rooms: " + rooms);
                    clear();
                }
                else if (option_manager == "7")
                {
                    printHeader();
                    subMenu("View Room Categories");
                    roomCategories view = new roomCategories();
                    view.roomType();
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
                            int isFound = foundCustomer(customerData, customerName, customerId);
                            if (isFound == -1)
                            {
                                Console.WriteLine("Customer is not staying in this hotel");
                            }
                            else
                            {
                                printHeader();
                                subMenu("Checkout");
                                roomCategories r = new roomCategories();
                                int bill = r.checkoutBill(customerData, isFound);
                                checkout(customerData, isFound, bill);
                                customerData.RemoveAt(isFound);
                                saveCustomerData(customersPath, customerData);
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
                    viewReviews(review);
                    clear();
                }
                else if (option_manager == "10")
                {
                    printHeader();
                    subMenu("View Ratings");
                    viewRatings(rating);
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
        }
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
        static int foundCustomer(List<customer> customerData, string name, string id)
        {
            int indexFound = -1;
            for (int i = 0; i < customerData.Count(); i++)
            {
                customer check = new customer();
                check = customerData[i];
                if (name == check.name && id == check.id)
                {
                    indexFound = i;
                    break;
                }
            }
            return indexFound;
        }
        static void addCustomer(List<customer> customerData, customer c, ref int roomCount)
        {
            customerData.Add(c);
            roomCount++;
        }

        // Update Customer
        static void updateCustomer(List<customer> customerData, string customersPath)
        {
            string option_update = "";
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
                    int isFound = foundCustomer(customerData, customerName, customerId);
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
                            customer c = new customer();
                            option_update = choice();
                            if (option_update == "1")
                            {
                                Console.Write("Enter Customer Name: ");
                                c.name = Console.ReadLine();
                                bool valid_name = isValid(c.name);
                                if (valid_name == true)
                                {
                                    c.updateName(customerData, isFound);
                                }
                                else if (valid_name == false)
                                {
                                    Console.WriteLine("Enter a Valid Name");
                                    clear();
                                }
                            }
                            else if (option_update == "2")
                            {
                                Console.Write("Enter Number of Person(1 - 5): ");
                                c.totalPerson = Console.ReadLine();
                                bool valid_totalPerson = check_person(c.totalPerson);
                                if (valid_totalPerson == true)
                                {
                                    c.updateTotalPerson(customerData, isFound);
                                }
                                else if (valid_totalPerson == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    clear();
                                }
                            }
                            else if (option_update == "3")
                            {
                                Console.Write("Enter Room Type: ");
                                c.roomType = Console.ReadLine();
                                bool valid_roomType = check_room_type(c.roomType);
                                if (valid_roomType == true)
                                {
                                    c.updateRoomType(customerData, isFound);
                                }
                                else if (valid_roomType == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    clear();
                                }
                            }
                            else if (option_update == "4")
                            {
                                Console.Write("Enter No. of Stay: ");
                                c.no_of_stay = Console.ReadLine();
                                bool valid_stay = check_stay(c.no_of_stay);
                                if (valid_stay == true)
                                {
                                    c.updateStayDay(customerData, isFound);
                                }
                                else if (valid_stay == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    clear();
                                }
                            }
                            else if (option_update == "5")
                            {
                                saveCustomerData(customersPath, customerData);
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

        // Search Customer
        static void searchCustomer(List<customer> customerData, int index)
        {
            printHeader();
            subMenu("Search Customer");
            customer info = new customer();
            info = customerData[index];
            Console.WriteLine("Customer Name: " + info.name);
            Console.WriteLine("Room Number: " + info.roomNumber);
            Console.WriteLine("Room Type: " + info.roomType);
            Console.WriteLine("Number of Person: " + info.totalPerson);
            Console.WriteLine("No. of Stay: " + info.no_of_stay);
            Console.WriteLine("CNIC: " + info.id);
            Console.WriteLine("City: " + info.city);
            Console.WriteLine("Contact: " + info.contact);
            Console.WriteLine("CheckIn Date: " + info.checkIn);
        }

        // View Booked Rooms
        static void bookedRooms(List<customer> customerData)
        {
            Console.WriteLine("Customer Name" + "\t" + "Room Number" + "\t" + "No. of Person" + "\t" + "No. of Stay" + "\t" + "Contact" + "\t\t" + "CheckIn Date" + "\t" + "Room Type");
            for (int i = 0; i < customerData.Count(); i++)
            {
                customer c = new customer();
                c = customerData[i];
                Console.WriteLine(c.name + "\t\t" + c.roomNumber + "\t\t" + c.totalPerson + "\t\t" + c.no_of_stay + "\t\t" + c.contact + "\t" + c.checkIn + "\t" + c.roomType);
            }
        }

        // View Available Rooms
        static int availableRooms(List<customer> customerData, int totalRoom)
        {
            int freeRooms, customerCount = 0;
            customerCount = customerData.Count();
            freeRooms = totalRoom - customerCount;
            return freeRooms;
        }

        // Checkout
        static void checkout(List<customer> customerData, int index, int bill)
        {
            customer info = new customer();
            info = customerData[index];
            Console.WriteLine("Customer Name: " + info.name);
            Console.WriteLine("Room Number: " + info.roomNumber);
            Console.WriteLine("Room Type: " + info.roomType);
            Console.WriteLine("Number of Person: " + info.totalPerson);
            Console.WriteLine("No. of Stay: " + info.no_of_stay);
            Console.WriteLine("CNIC: " + info.id);
            Console.WriteLine("City: " + info.city);
            Console.WriteLine("Contact: " + info.contact);
            Console.WriteLine("CheckIn Date: " + info.checkIn);
            Console.WriteLine("Total Bill: " + bill);
        }

        // Reviews
        static void viewReviews(List<feedback> review)
        {
            int reviewCount = review.Count();
            if (reviewCount == 0)
            {
                Console.WriteLine("No Reviews");
            }
            else
            {
                for (int index = 0; index < reviewCount; index++)
                {
                    feedback r = new feedback();
                    r = review[index];
                    Console.WriteLine("> " + r);
                }
            }
        }

        // Ratings
        static void viewRatings(List<feedback> rating)
        {
            int ratingCount = rating.Count();
            if (ratingCount == 0)
            {
                Console.WriteLine("No Ratings");
            }
            else
            {
                for (int index = 0; index < ratingCount; index++)
                {
                    feedback r = new feedback();
                    r = rating[index];
                    Console.WriteLine("> " + r);
                }
            }
        }
    }
}
