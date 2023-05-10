using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V4.BL
{
    class customer
    {
        public string name;
        public string id;
        public string contact;
        public string city;
        public string totalPerson;
        public string roomType;
        public int roomNumber;
        public string no_of_stay;
        public string checkIn;
        public customer()
        {

        }

        // Add Customer
        public bool checkCustomer(List<customer> customerData)
        {
            bool isNew = true;
            foreach (customer check in customerData)
            {
                if (id == check.id)
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }

        // Update Customer
        public void updateName(List<customer> customerData, int index)
        {
            customer change = new customer();
            change = customerData[index];
            change.name = name;
        }
        public void updateTotalPerson(List<customer> customerData, int index)
        {
            customer change = new customer();
            change = customerData[index];
            change.totalPerson = totalPerson;
        }
        public void updateRoomType(List<customer> customerData, int index)
        {
            customer change = new customer();
            change = customerData[index];
            change.roomType = roomType;
        }
        public void updateStayDay(List<customer> customerData, int index)
        {
            customer change = new customer();
            change = customerData[index];
            change.no_of_stay = no_of_stay;
        }

        // Room Suggestion
        public void roomSuggestion()
        {
            if (totalPerson == "1")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Single");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("---------------------");
            }
            else if (totalPerson == "2")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Double");
                Console.WriteLine("> Twin");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
            else if (totalPerson == "3")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> Triple");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
            else if (totalPerson == "4" || totalPerson == "5")
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Recommended Room Type");
                Console.WriteLine("> King");
                Console.WriteLine("> Executive");
                Console.WriteLine("---------------------");
            }
        }
    }
}
