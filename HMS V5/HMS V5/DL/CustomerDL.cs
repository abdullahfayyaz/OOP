using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V5.BL;
using HMS_V5.UI;

namespace HMS_V5.DL
{
    class CustomerDL
    {
        static List<Customer> customerList = new List<Customer>();

        // Add Customer
        public static bool checkCustomer(string id)
        {
            bool isNew = true;
            foreach (Customer check in customerList)
            {
                if (id == check.id)
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }
        public static void addCustomerIntoList(Customer info)
        {
            customerList.Add(info);
        }
        public static int foundCustomer(Customer info)
        {
            int indexFound = -1;
            for (int i = 0; i < customerList.Count(); i++)
            {
                if (info.name == customerList[i].name && info.id == customerList[i].id)
                {
                    indexFound = i;
                    break;
                }
            }
            return indexFound;
        }

        // Store Customer Data in File
        public static void saveCustomerData(string customersPath)
        {
            StreamWriter file = new StreamWriter(customersPath, false);
            for (int i = 0; i < customerList.Count(); i++)
            {
                Customer info = new Customer();
                info = customerList[i];
                file.WriteLine(info.name + "," + info.id + "," + info.contact + "," + info.city + "," + info.totalPerson + "," + info.roomType + "," + info.no_of_stay + "," + info.checkIn + "," + info.roomNumber);
            }
            file.Flush();
            file.Close();
        }

        // Update Customer
        public static void updateName(string name, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.name = name;
        }
        public static void updateTotalPerson(string totalPerson, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.totalPerson = totalPerson;
        }
        public static void updateRoomType(string roomType, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.roomType = roomType;
        }
        public static void updateStayDay(string no_of_stay, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.no_of_stay = no_of_stay;
        }

        // Search Customer
        public static void searchCustomerInList(Customer info)
        {
            foreach (Customer check in customerList)
            {
                if (check.name == info.name && check.id == info.id)
                {
                    ManagerUI.searchCustomer(check);
                    break;
                }
            }
        }

        // Remove Customer
        public static void removeCustomer(int index)
        {
            customerList.RemoveAt(index);
        }

        // View Booked Rooms
        public static void bookedRooms()
        {
            Console.WriteLine("Customer Name" + "\t" + "Room Number" + "\t" + "No. of Person" + "\t" + "No. of Stay" + "\t" + "Contact" + "\t\t" + "CheckIn Date" + "\t" + "Room Type");
            for (int i = 0; i < customerList.Count(); i++)
            {
                Customer c = new Customer();
                c = customerList[i];
                Console.WriteLine(c.name + "\t\t" + c.roomNumber + "\t\t" + c.totalPerson + "\t\t" + c.no_of_stay + "\t\t" + c.contact + "\t" + c.checkIn + "\t" + c.roomType);
            }
        }

        // View Available Rooms
        public static int availableRooms(int totalRoom)
        {
            int freeRooms, customerCount = 0;
            customerCount = customerList.Count();
            freeRooms = totalRoom - customerCount;
            return freeRooms;
        }

        // Checkout
        public static int checkoutBill(int index)
        {
            int bill = 0;
            Customer c = new Customer();
            Room r = new Room();
            c = customerList[index];
            int stay_days = int.Parse(c.no_of_stay);
            if (c.roomType == "single" || c.roomType == "Single")
            {
                bill = r.type_single * stay_days;
            }
            else if (c.roomType == "double" || c.roomType == "Double")
            {
                bill = r.type_double * stay_days;
            }
            else if (c.roomType == "triple" || c.roomType == "Triple")
            {
                bill = r.type_triple * stay_days;
            }
            else if (c.roomType == "twin" || c.roomType == "Twin")
            {
                bill = r.type_twin * stay_days;
            }
            else if (c.roomType == "executive" || c.roomType == "Executive")
            {
                bill = r.type_executive * stay_days;
            }
            else if (c.roomType == "king" || c.roomType == "King")
            {
                bill = r.type_king * stay_days;
            }
            return bill;
        }
        public static void CheckOutFromList(Customer info, int bill)
        {
            foreach (Customer check in customerList)
            {
                if (check.name == info.name && check.id == info.id)
                {
                    ManagerUI.checkout(check, bill);
                    break;
                }
            }
        }
    }
}
