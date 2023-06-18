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
        public static void managerMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Main Menu >");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Select one of the following options number...");
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Console.WriteLine("11- Add Staff Member");
            Console.WriteLine("12- Remove Staff Member");
            Console.WriteLine("13- View Staff Members");
            Console.WriteLine("14- Logout");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("15- Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void managerInterface()
        {
            string option_manager = "";
            while (true)
            {
                Interface.printHeader();
                managerMenu();
                option_manager = Interface.choice();
                if (option_manager == "1")
                {
                    addCustomer();
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
                            if (isFound == -1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Customer is not staying in this hotel");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                PersonDL.searchCustomerInList(info);
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
                else if (option_manager == "4")
                {
                    Interface.printHeader();
                    Interface.subMenu("Remove Customer");
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
                        bool id_valid = Validation.id_check(customerId);
                        if (id_valid == true)
                        {
                            Customer info = new Customer(customerName, customerId);
                            int isFound = PersonDL.foundCustomer(info);
                            if (isFound == -1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Customer Not Found");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                PersonDL.removePerson(isFound);
                                PersonDL.saveData();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Customer Removed");
                                Console.ForegroundColor = ConsoleColor.White;
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
                else if (option_manager == "5")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Booked Rooms");
                    PersonDL.viewBookedRooms();
                    Interface.clear();
                }
                else if (option_manager == "6")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Available Rooms");
                    Room info = new Room();
                    int rooms = PersonDL.availableRooms(info.getTotalRoom());
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Total Rooms: " + info.getTotalRoom());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("No. of Available Rooms: " + rooms);
                    Console.ForegroundColor = ConsoleColor.White;
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
                        bool id_valid = Validation.id_check(customerId);
                        if (id_valid == true)
                        {
                            Customer info = new Customer(customerName, customerId);
                            int isFound = PersonDL.foundCustomer(info);
                            if (isFound == -1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Customer is not staying in this hotel");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Interface.printHeader();
                                Interface.subMenu("Checkout");
                                PersonDL.checkoutBill(isFound);
                                PersonDL.CheckOutFromList(info);
                                PersonDL.removePerson(isFound);
                                PersonDL.saveData();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Thank You!");
                                Console.ForegroundColor = ConsoleColor.White;
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
                else if (option_manager == "9")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Reviews");
                    PersonDL.viewReviews();
                    Interface.clear();
                }
                else if (option_manager == "10")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Ratings");
                    PersonDL.viewRatings();
                    Interface.clear();
                }
                else if (option_manager == "11")
                {
                    StaffMemberUI.addSatffMember();
                }
                else if (option_manager == "12")
                {
                    Interface.printHeader();
                    Interface.subMenu("Remove Staff Member");
                    StaffMemberUI.removeStaffMemember();
                    Interface.clear();
                }
                else if (option_manager == "13")
                {
                    Interface.printHeader();
                    Interface.subMenu("View Staff Members");
                    PersonDL.viewStaffMember();
                    Interface.clear();
                }
                else if (option_manager == "14")
                {
                    break;
                }
                else if (option_manager == "15")
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

        // Add Customer
        public static void addCustomer()
        {
        there:
            Interface.printHeader();
            Interface.subMenu("Add Customer");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter Name: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string name = Console.ReadLine();
            bool valid = Validation.isValid(name);
            if (valid == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter CNIC: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string id = Console.ReadLine();
                bool valid_id = Validation.id_check(id);
                if (valid_id == true)
                {
                    bool isCheck = PersonDL.checkCustomer(id);
                    if (isCheck == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Enter Contact: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        string contact = Console.ReadLine();
                        bool valid_contact = Validation.contact_check(contact);
                        if (valid_contact == true)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Enter City: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            string city = Console.ReadLine();
                            bool valid_city = Validation.isValid(city);
                            if (valid_city == true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter Number of Person(1 - 5): ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string totalPerson = (Console.ReadLine());
                                bool valid_totalPerson = Validation.check_person(totalPerson);
                                if (valid_totalPerson == true)
                                {
                                    RoomUI.roomSuggestion(totalPerson);
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write("Enter Room Type: ");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    string roomType = Console.ReadLine();
                                    bool valid_roomType = Validation.check_room_type(roomType);
                                    if (valid_roomType == true)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.Write("Enter No. of Stay: ");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        string no_of_stay = (Console.ReadLine());
                                        bool valid_stay = Validation.check_stay(no_of_stay);
                                        if (valid_stay == true)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.Write("Enter CheckIn Date (DD/MM/YYYY): ");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            string checkIn = Console.ReadLine();
                                            bool valid_date = Validation.date_check(checkIn);
                                            if (valid_date == true)
                                            {
                                                int roomNumber = Room.roomCount++;
                                                Customer info = new Customer(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn);
                                                PersonDL.addPersonIntoList(info);
                                                PersonDL.saveData();
                                                Room.roomCount++;
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("Customer Added");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else if (valid_date == false)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("Enter a Valid Date");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Interface.clear();
                                                goto there;
                                            }
                                        }
                                        else if (valid_stay == false)
                                        {
                                            Interface.wrongInput();
                                            Interface.clear();
                                            goto there;
                                        }
                                    }
                                    else if (valid_roomType == false)
                                    {
                                        Interface.wrongInput();
                                        Interface.clear();
                                        goto there;
                                    }
                                }
                                else if (valid_totalPerson == false)
                                {
                                    Interface.wrongInput();
                                    Interface.clear();
                                    goto there;
                                }
                            }
                            else if (valid_city == false)
                            {
                                Interface.wrongInput();
                                Interface.clear();
                                goto there;
                            }
                        }
                        else if (valid_contact == false)
                        {
                            Interface.NotValidContact();
                            Interface.clear();
                            goto there;
                        }
                    }
                    else if (isCheck == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Already Exist");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else if (valid_id == false)
                {
                    Interface.InvalidCNICFormat();
                    Interface.clear();
                    goto there;
                }
            }
            else if (valid == false)
            {
                Interface.NotValidName();
                Interface.clear();
                goto there;
            }
            Interface.clear();
        }
        // Update Customer
        public static void updateMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Select option to make changes....");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1- Customer Name");
            Console.WriteLine("2- Number of Person");
            Console.WriteLine("3- Room Type");
            Console.WriteLine("4- Number of Stay");
            Console.WriteLine("5- Save Changes");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        public static void updateCustomer()
        {
            string option_update;
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
                    if (isFound == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Customer Not Found");
                        Console.ForegroundColor = ConsoleColor.White;
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
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter Customer Name: ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string name = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                bool valid_name = Validation.isValid(name);
                                if (valid_name == true)
                                {
                                    PersonDL.updateName(name, isFound);
                                }
                                else if (valid_name == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Enter a Valid Name");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "2")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter Number of Person(1 - 5): ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string totalPerson = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                bool valid_totalPerson = Validation.check_person(totalPerson);
                                if (valid_totalPerson == true)
                                {
                                    PersonDL.updateTotalPerson(totalPerson, isFound);
                                }
                                else if (valid_totalPerson == false)
                                {
                                    Interface.wrongInput();
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "3")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter Room Type: ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string roomType = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                bool valid_roomType = Validation.check_room_type(roomType);
                                if (valid_roomType == true)
                                {
                                    PersonDL.updateRoomType(roomType, isFound);
                                }
                                else if (valid_roomType == false)
                                {
                                    Interface.wrongInput();
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "4")
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("Enter No. of Stay: ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                string no_of_stay = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                bool valid_stay = Validation.check_stay(no_of_stay);
                                if (valid_stay == true)
                                {
                                    PersonDL.updateStayDay(no_of_stay, isFound);
                                }
                                else if (valid_stay == false)
                                {
                                    Interface.wrongInput();
                                    Interface.clear();
                                }
                            }
                            else if (option_update == "5")
                            {
                                PersonDL.saveData();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Successfully Saved");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                        }
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
        }

        // Search Customer
        public static void searchCustomer(Person info)
        {
            Interface.printHeader();
            Interface.subMenu("Search Customer");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Customer Name: " + info.getName());
            Console.WriteLine("Room Number: " + info.getRoomNumber());
            Console.WriteLine("Room Type: " + info.getRoomType());
            Console.WriteLine("Number of Person: " + info.getTotalPerson());
            Console.WriteLine("No. of Stay: " + info.getNoOfStay());
            Console.WriteLine("CNIC: " + info.getID());
            Console.WriteLine("City: " + info.getCity());
            Console.WriteLine("Contact: " + info.getContact());
            Console.WriteLine("CheckIn Date: " + info.getCheckIn());
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Checkout
        public static void checkout(Person info)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            Console.ForegroundColor = ConsoleColor.White;
        }

        // View Booked Rooms
        public static void bookedRooms(List<Person> personList)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Customer Name" + "\t" + "Room Number" + "\t" + "No. of Person" + "\t" + "No. of Stay" + "\t" + "Contact" + "\t\t" + "CheckIn Date" + "\t" + "Room Type");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].getRole() == "Customer")
                {
                    Console.WriteLine(personList[i].getName() + "\t\t" + personList[i].getRoomNumber() + "\t\t" + personList[i].getTotalPerson() + "\t\t" + personList[i].getNoOfStay() + "\t\t" + personList[i].getContact() + "\t" + personList[i].getCheckIn() + "\t" + personList[i].getRoomType());
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NoCustomerAdded()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Rooms Not Booked");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
