using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.DL;

namespace HMS_V6.UI
{
    class ManagerUI
    {
        public static string customersPath = "C:\\Users\\HP\\Documents\\STUDY\\2nd Semester\\OOP TASK\\HMS V6\\Customers.txt";
        public static void managerMenu()
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

        public static void managerInterface(ref int roomCount, int totalRoom, ref bool exit_app)
        {
            string option_manager = "";
            while (true)
            {
                Interface.printHeader();
                managerMenu();
                option_manager = Interface.choice();
                if (option_manager == "1")
                {
                there:
                    Interface.printHeader();
                    Interface.subMenu("Add Customer");
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    bool valid = Validation.isValid(name);
                    if (valid == true)
                    {
                        Console.Write("Enter CNIC: ");
                        string id = Console.ReadLine();
                        bool valid_id = Validation.id_check(id);
                        if (valid_id == true)
                        {
                            bool isCheck = CustomerDL.checkCustomer(id);
                            if (isCheck == true)
                            {
                                Console.Write("Enter Contact: ");
                                string contact = Console.ReadLine();
                                bool valid_contact = Validation.contact_check(contact);
                                if (valid_contact == true)
                                {
                                    Console.Write("Enter City: ");
                                    string city = Console.ReadLine();
                                    bool valid_city = Validation.isValid(city);
                                    if (valid_city == true)
                                    {
                                        Console.Write("Enter Number of Person(1 - 5): ");
                                        string totalPerson = (Console.ReadLine());
                                        bool valid_totalPerson = Validation.check_person(totalPerson);
                                        if (valid_totalPerson == true)
                                        {
                                            RoomUI.roomSuggestion(totalPerson);
                                            Console.Write("Enter Room Type: ");
                                            string roomType = Console.ReadLine();
                                            bool valid_roomType = Validation.check_room_type(roomType);
                                            if (valid_roomType == true)
                                            {
                                                Console.Write("Enter No. of Stay: ");
                                                string no_of_stay = (Console.ReadLine());
                                                bool valid_stay = Validation.check_stay(no_of_stay);
                                                if (valid_stay == true)
                                                {
                                                    Console.Write("Enter CheckIn Date (DD/MM/YYYY): ");
                                                    string checkIn = Console.ReadLine();
                                                    bool valid_date = Validation.date_check(checkIn);
                                                    if (valid_date == true)
                                                    {
                                                        int roomNumber = roomCount;
                                                        Customer info = new Customer(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn, 0);
                                                        CustomerDL.addCustomerIntoList(info);
                                                        CustomerDL.saveCustomerData(customersPath);
                                                        roomCount++;
                                                        Console.WriteLine("Customer Added");
                                                    }
                                                    else if (valid_date == false)
                                                    {
                                                        Console.WriteLine("Enter a Valid Date");
                                                        Interface.clear();
                                                        goto there;
                                                    }
                                                }
                                                else if (valid_stay == false)
                                                {
                                                    Console.WriteLine("Wrong Input\nTry Again");
                                                    Interface.clear();
                                                    goto there;
                                                }
                                            }
                                            else if (valid_roomType == false)
                                            {
                                                Console.WriteLine("Wrong Input\nTry Again");
                                                Interface.clear();
                                                goto there;
                                            }
                                        }
                                        else if (valid_totalPerson == false)
                                        {
                                            Console.WriteLine("Wrong Input\nTry Again");
                                            Interface.clear();
                                            goto there;
                                        }
                                    }
                                    else if (valid_city == false)
                                    {
                                        Console.WriteLine("Wrong Input\nTry Again");
                                        Interface.clear();
                                        goto there;
                                    }
                                }
                                else if (valid_contact == false)
                                {
                                    Console.WriteLine("Enter a Valid Number");
                                    Interface.clear();
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
                            Interface.clear();
                            goto there;
                        }
                    }
                    else if (valid == false)
                    {
                        Console.WriteLine("Enter a Valid Name");
                        Interface.clear();
                        goto there;
                    }
                    Interface.clear();
                }
                else if (option_manager == "2")
                {
                    Interface.printHeader();
                    Interface.subMenu("Update Customer");
                    updateCustomer();
                    Interface.clear();
                }
                else if (option_manager == "3")
                {
                    Interface.printHeader();
                    Interface.subMenu("Search Customer");
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
                                Console.WriteLine("Customer is not staying in this hotel");
                            }
                            else
                            {
                                CustomerDL.searchCustomerInList(info);
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
                    Interface.clear();
                }
                else if (option_manager == "4")
                {
                    Interface.printHeader();
                    Interface.subMenu("Remove Customer");
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
                                Console.WriteLine("Customer Not Found");
                            }
                            else
                            {
                                CustomerDL.removeCustomer(isFound);
                                CustomerDL.saveCustomerData(customersPath);
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
                    Interface.clear();
                }
                else if (option_manager == "5")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Booked Rooms");
                    CustomerDL.bookedRooms();
                    Interface.clear();
                }
                else if (option_manager == "6")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Available Rooms");
                    int rooms = CustomerDL.availableRooms(totalRoom);
                    Console.WriteLine("Total Rooms: " + totalRoom);
                    Console.WriteLine("No. of Available Rooms: " + rooms);
                    Interface.clear();
                }
                else if (option_manager == "7")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Room Categories");
                    RoomUI.roomType();
                    Interface.clear();
                }
                else if (option_manager == "8")
                {
                    Interface.printHeader();
                    Interface.subMenu("Checkout");
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
                                Console.WriteLine("Customer is not staying in this hotel");
                            }
                            else
                            {
                                Interface.printHeader();
                                Interface.subMenu("Checkout");
                                CustomerDL.checkoutBill(isFound);
                                CustomerDL.CheckOutFromList(info);
                                CustomerDL.removeCustomer(isFound);
                                CustomerDL.saveCustomerData(customersPath);
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
                    Interface.clear();
                }
                else if (option_manager == "9")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Reviews");
                    ReviewDL.viewReviews();
                    Interface.clear();
                }
                else if (option_manager == "10")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Ratings");
                    RatingDL.viewRatings();
                    Interface.clear();
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
                    Interface.clear();
                }
            }
        }
        // Update Customer
        public static void updateMenu()
        {
            Console.WriteLine("Select option to make changes....");
            Console.WriteLine("1- Customer Name");
            Console.WriteLine("2- Number of Person");
            Console.WriteLine("3- Room Type");
            Console.WriteLine("4- Number of Stay");
            Console.WriteLine("5- Save Changes");
            Console.WriteLine();
        }
        public static void updateCustomer()
        {
            string option_update = "";
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
                        Console.WriteLine("Customer Not Found");
                    }
                    else
                    {
                        while (true)
                        {
                            Interface.printHeader();
                            Interface.subMenu("Update Customer");
                            updateMenu();
                            option_update = Interface.choice();
                            if (option_update == "1")
                            {
                                Console.Write("Enter Customer Name: ");
                                string name = Console.ReadLine();
                                bool valid_name = Validation.isValid(name);
                                if (valid_name == true)
                                {
                                    CustomerDL.updateName(name, isFound);
                                }
                                else if (valid_name == false)
                                {
                                    Console.WriteLine("Enter a Valid Name");
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "2")
                            {
                                Console.Write("Enter Number of Person(1 - 5): ");
                                string totalPerson = Console.ReadLine();
                                bool valid_totalPerson = Validation.check_person(totalPerson);
                                if (valid_totalPerson == true)
                                {
                                    CustomerDL.updateTotalPerson(totalPerson, isFound);
                                }
                                else if (valid_totalPerson == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "3")
                            {
                                Console.Write("Enter Room Type: ");
                                string roomType = Console.ReadLine();
                                bool valid_roomType = Validation.check_room_type(roomType);
                                if (valid_roomType == true)
                                {
                                    CustomerDL.updateRoomType(roomType, isFound);
                                }
                                else if (valid_roomType == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "4")
                            {
                                Console.Write("Enter No. of Stay: ");
                                string no_of_stay = Console.ReadLine();
                                bool valid_stay = Validation.check_stay(no_of_stay);
                                if (valid_stay == true)
                                {
                                    CustomerDL.updateStayDay(no_of_stay, isFound);
                                }
                                else if (valid_stay == false)
                                {
                                    Console.WriteLine("Wrong Input\nTry Again");
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "5")
                            {
                                CustomerDL.saveCustomerData(customersPath);
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

        // Search Customer
        public static void searchCustomer(Customer info)
        {
            Interface.printHeader();
            Interface.subMenu("Search Customer");
            Console.WriteLine("Customer Name: " + info.getName());
            Console.WriteLine("Room Number: " + info.getRoomNumber());
            Console.WriteLine("Room Type: " + info.getRoomType());
            Console.WriteLine("Number of Person: " + info.getTotalPerson());
            Console.WriteLine("No. of Stay: " + info.getNoOfStay());
            Console.WriteLine("CNIC: " + info.getID());
            Console.WriteLine("City: " + info.getCity());
            Console.WriteLine("Contact: " + info.getContact());
            Console.WriteLine("CheckIn Date: " + info.getCheckIn());
        }

        // Checkout
        public static void checkout(Customer info)
        {
            Console.WriteLine("Customer Name: " + info.getName());
            Console.WriteLine("Room Number: " + info.getRoomNumber());
            Console.WriteLine("Room Type: " + info.getRoomType());
            Console.WriteLine("Number of Person: " + info.getTotalPerson());
            Console.WriteLine("No. of Stay: " + info.getNoOfStay());
            Console.WriteLine("CNIC: " + info.getID());
            Console.WriteLine("City: " + info.getCity());
            Console.WriteLine("Contact: " + info.getContact());
            Console.WriteLine("CheckIn Date: " + info.getCheckIn());
            Console.WriteLine("Total Bill: " + info.getBill());
        }
    }
}
