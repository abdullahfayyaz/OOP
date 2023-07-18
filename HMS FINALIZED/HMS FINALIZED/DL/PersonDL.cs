using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_FINALIZED.BL;

namespace HMS_FINALIZED.DL
{
    class PersonDL
    {
        private static List<Person> personList = new List<Person>();
        internal static List<Person> PersonList { get => personList; set => personList = value; }

        // Add Customer and Staff Member Into List
        public static void addPersonIntoList(Person info)
        {
            personList.Add(info);
        }

        // Check Customer
        public static bool checkCustomer(string name, string id)
        {
            bool isNew = true;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
                {
                    if (name == personList[x].getName() || id == personList[x].getID())
                    {
                        isNew = false;
                        break;
                    }
                }
            }
            return isNew;
        }
        public static int foundCustomer(Customer info)
        {
            int indexFound = -1;
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].getRole() == "Customer")
                {
                    if (info.getName() == personList[i].getName() && info.getID() == personList[i].getID())
                    {
                        indexFound = i;
                        break;
                    }
                }
            }
            return indexFound;
        }
        public static int assignRoom()
        {
            int maxRoom = personList.Max(r => r.getRoomNumber());
            int unassignedRoom = Room.roomCount;
            for (int x = 1; x <= maxRoom + 1; x++)
            {
                if (!personList.Any(r => r.getRoomNumber() == x))
                {
                    unassignedRoom = x;
                    break;
                }
            }
            return unassignedRoom;
        }

        // Store Data in File
        public static void saveData()
        {
            string customersPath = "Person.txt";
            StreamWriter file = new StreamWriter(customersPath, false);
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].getRole() == "Customer")
                {
                    file.WriteLine(personList[i].getRole() + "," + personList[i].getName() + "," + personList[i].getID() + "," + personList[i].getContact() + "," + personList[i].getCity() + "," + personList[i].getTotalPerson() + "," + personList[i].getRoomType() + "," + personList[i].getCheckInDate() + "," + personList[i].getCheckOutDate() + "," + personList[i].getRoomNumber() + "," + personList[i].getBill() + "," + personList[i].getReview() + "," + personList[i].getRating() + "," + personList[i].getReviewCheck() + "," + personList[i].getRatingCheck());
                }
                else if (personList[i].getRole() == "Staff")
                {
                    file.WriteLine(personList[i].getRole() + "," + personList[i].getName() + "," + personList[i].getID() + "," + personList[i].getContact() + "," + personList[i].getCity() + "," + personList[i].getDuty());
                }
            }
            file.Flush();
            file.Close();
        }

        // Reading File for Storing Data in Arrays
        public static void loadData()
        {
            string customersPath = "Person.txt";
            if (File.Exists(customersPath))
            {
                StreamReader file = new StreamReader(customersPath);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    if (splittedRecord[0] == "Customer")
                    {
                        string name = splittedRecord[1];
                        string id = splittedRecord[2];
                        string contact = splittedRecord[3];
                        string city = splittedRecord[4];
                        string totalPerson = splittedRecord[5];
                        string roomType = splittedRecord[6];
                        string checkIn = splittedRecord[7];
                        string checkOut = splittedRecord[8];
                        int roomNumber = int.Parse(splittedRecord[9]);
                        string review = splittedRecord[11];
                        string rating = splittedRecord[12];
                        bool reviewCheck = bool.Parse(splittedRecord[13]);
                        bool ratingCeck = bool.Parse(splittedRecord[14]);
                        Customer info = new Customer(name, id, contact, city, totalPerson, roomType, roomNumber, checkIn, checkOut);
                        info.setReview(review);
                        info.setRating(rating);
                        info.setReviewCheck(reviewCheck);
                        info.setRatingCheck(ratingCeck);
                        addPersonIntoList(info);
                        Room.roomCount++;
                    }
                    else if (splittedRecord[0] == "Staff")
                    {
                        string name = splittedRecord[1];
                        string id = splittedRecord[2];
                        string contact = splittedRecord[3];
                        string city = splittedRecord[4];
                        string duty = splittedRecord[5];
                        StaffMember info = new StaffMember(name, id, contact, city, duty);
                        addPersonIntoList(info);
                    }
                }
                file.Close();
            }
        }

        // Update Customer
        public static void updateName(string name, int index)
        {
            personList[index].setName(name);
        }
        public static void updateTotalPerson(string totalPerson, int index)
        {
            personList[index].setTotalPerson(totalPerson);
        }
        public static void updateRoomType(string roomType, int index)
        {
            personList[index].setRoomType(roomType);
        }
        public static void updateCheckoutDate(string checkOutDate, int index)
        {
            personList[index].setCheckOutDate(checkOutDate);
        }

        // Search Customer
        public static void searchCustomerInList(int index)
        {
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
                {
                    Person check = personList[x];
                    if (check.getName() == personList[index].getName() && check.getID() == personList[index].getID())
                    {
                      //  ManagerUI.searchCustomer(check);
                        break;
                    }
                }
            }
        }

        // Count Customer
        public static int countCustomer()
        {
            int customerCount = 0;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
                {
                    customerCount++;
                }
            }
            return customerCount;
        }

        // View Booked Rooms
        public static void viewBookedRooms()
        {
            int customerCount = countCustomer();
            if (customerCount == 0)
            {
               // ManagerUI.NoCustomerAdded();
            }
            else
            {
               // ManagerUI.bookedRooms(personList);
            }
        }

        // View Available Rooms
        public static int availableRooms(int totalRoom)
        {
            int freeRooms, customerCount = 0;
            customerCount = countCustomer();
            freeRooms = totalRoom - customerCount;
            return freeRooms;
        }

        // Checkout
        public static void checkoutBill(int index)
        {
            /*
            float bill = 0F;
            Person c = personList[index];
            Room r = new Room();
            int stay_days = int.Parse(c.getNoOfStay());
            if (c.getRoomType() == "Single")
            {
                bill = r.TypeSingle * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "Double")
            {
                bill = r.TypeDouble * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "Triple")
            {
                bill = r.TypeTriple * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "Twin")
            {
                bill = r.TypeTwin * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "Executive")
            {
                bill = r.TypeExecutive * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "King")
            {
                bill = r.TypeKing * stay_days;
                c.setBill(bill);
            }
            */
        }
        public static void CheckOutFromList(int index)
        {
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
                {
                    Person check = personList[x];
                    if (check.getName() == personList[index].getName() && check.getID() == personList[index].getID())
                    {
                       // ManagerUI.checkout(check);
                        break;
                    }
                }
            }
        }

        // Reviews
        public static void viewReviews()
        {
            int reviewCount = personList.Count(obj => obj.getReviewCheck() == true);
            if (reviewCount == 0)
            {
               // CustomerUI.NoReviews();
            }
            else
            {
                for (int x = 0; x < personList.Count; x++)
                {
                   // CustomerUI.displayReview(personList[x]);
                }
            }
        }
        public static void customerReview(int index)
        {
           // personList[index].setReview(CustomerUI.addReview());
            personList[index].setReviewCheck(true);
        }

        // Ratings
        public static void viewRatings()
        {
            int ratingCount = personList.Count(obj => obj.getRatingCheck() == true);
            if (ratingCount == 0)
            {
               // CustomerUI.NoRatings();
            }
            else
            {
                for (int x = 0; x < personList.Count; x++)
                {
                  //  CustomerUI.displayRating(personList[x]);
                }
            }
        }
        public static void customerRating(int index)
        {
           // personList[index].setRating(Customer.addRating());
            personList[index].setRatingCheck(true);
        }

        // Check Staff Member
        public static bool checkStaffMember(string id)
        {
            bool isNew = true;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Staff")
                {
                    if (id == personList[x].getID())
                    {
                        isNew = false;
                        break;
                    }
                }
            }
            return isNew;
        }

        // Find Staff Member
        public static int foundStaffMember(StaffMember info)
        {
            int indexFound = -1;
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].getRole() == "Staff")
                {
                    if (info.getName() == personList[i].getName() && info.getID() == personList[i].getID())
                    {
                        indexFound = i;
                        break;
                    }
                }
            }
            return indexFound;
        }

        // Remove Person
        public static void removePerson(int index)
        {
            personList.RemoveAt(index);
        }

        // Count Staff Member
        public static int countSatffMember()
        {
            int staffCount = 0;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Staff")
                {
                    staffCount++;
                }
            }
            return staffCount;
        }

        // View Staff Member
        public static void viewStaffMember()
        {
            int memberCount = countSatffMember();
            if (memberCount == 0)
            {
              //  StaffMemberUI.NoStaffMember();
            }
            else
            {
              //  StaffMemberUI.displayStaffMember(personList);
            }
        }
    }
}
