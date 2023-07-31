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
                if (personList[x].Role == "Customer")
                {
                    if (name == personList[x].Name || id == personList[x].Id)
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
                if (personList[i].Role == "Customer")
                {
                    if (info.Name == personList[i].Name && info.Id == personList[i].Id)
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
            int maxRoom = personList.Max(r => r.RoomNumber);
            int unassignedRoom = Room.roomCount;
            for (int x = 1; x <= maxRoom + 1; x++)
            {
                if (!personList.Any(r => r.RoomNumber == x))
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
                if (personList[i].Role == "Customer")
                {
                    file.WriteLine(personList[i].Role + "," + personList[i].Name + "," + personList[i].Id + "," + personList[i].Contact + "," + personList[i].City + "," + personList[i].TotalPerson + "," + personList[i].RoomType + "," + personList[i].CheckInDate + "," + personList[i].CheckOutDate + "," + personList[i].RoomNumber + "," + personList[i].Bill + "," + personList[i].Review + "," + personList[i].Rating + "," + personList[i].ReviewCheck + "," + personList[i].RatingCheck);
                }
                else if (personList[i].Role == "Staff")
                {
                    file.WriteLine(personList[i].Role + "," + personList[i].Name + "," + personList[i].Id + "," + personList[i].Contact + "," + personList[i].City + "," + personList[i].Designation);
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
                        info.Review = review;
                        info.Rating = rating;
                        info.ReviewCheck = reviewCheck;
                        info.RatingCheck = ratingCeck;
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
            personList[index].Name = name;
        }
        public static void updateTotalPerson(string totalPerson, int index)
        {
            personList[index].TotalPerson = totalPerson;
        }
        public static void updateRoomType(string roomType, int index)
        {
            personList[index].RoomType = roomType;
        }
        public static void updateCheckoutDate(string checkOutDate, int index)
        {
            personList[index].CheckOutDate = checkOutDate;
        }

        // Count Customer
        public static int countCustomer()
        {
            int customerCount = 0;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].Role == "Customer")
                {
                    customerCount++;
                }
            }
            return customerCount;
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

        public static int calculateStayDays(int index)
        {
            DateTime checkin;
            DateTime checkout;
            Person c = personList[index];
            checkin = Convert.ToDateTime(c.CheckInDate);
            checkout = Convert.ToDateTime(c.CheckOutDate);
            int days;
            days = (int)(checkout - checkin).TotalDays;
            return days;
        }
        public static void calculateBill(int index)
        {
            float bill = 0F;
            Person c = personList[index];
            Room r = new Room();
            int stay_days = calculateStayDays(index);
            if (c.RoomType == "Single")
            {
                bill = r.TypeSingle * stay_days;
                c.Bill = bill;
            }
            else if (c.RoomType == "Double")
            {
                bill = r.TypeDouble * stay_days;
                c.Bill = bill;
            }
            else if (c.RoomType == "Triple")
            {
                bill = r.TypeTriple * stay_days;
                c.Bill = bill;
            }
            else if (c.RoomType == "Twin")
            {
                bill = r.TypeTwin * stay_days;
                c.Bill = bill;
            }
            else if (c.RoomType == "Executive")
            {
                bill = r.TypeExecutive * stay_days;
                c.Bill = bill;
            }
            else if (c.RoomType == "King")
            {
                bill = r.TypeKing * stay_days;
                c.Bill = bill;
            }
        }

        // Reviews
        public static void customerReview(string review, int index)
        {
            personList[index].Review = review;
            personList[index].ReviewCheck = true;
        }

        // Ratings
        public static void customerRating(string rating, int index)
        {
            personList[index].Rating = rating;
            personList[index].RatingCheck = true;
        }

        // Check Staff Member
        public static bool checkStaffMember(string name, string id)
        {
            bool isNew = true;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].Role == "Staff")
                {
                    if (name == personList[x].Name || id == personList[x].Id)
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
                if (personList[i].Role == "Staff")
                {
                    if (info.Name == personList[i].Name && info.Id == personList[i].Id)
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
                if (personList[x].Role == "Staff")
                {
                    staffCount++;
                }
            }
            return staffCount;
        }
    }
}
