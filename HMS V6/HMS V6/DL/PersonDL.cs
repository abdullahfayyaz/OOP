using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.UI;

namespace HMS_V6.DL
{
    class PersonDL
    {
        private static List<Person> personList = new List<Person>();
        private static List<String> reviewList = new List<String>();
        private static List<String> ratingList = new List<String>();

        // Add Customer
        public static void addCustomerIntoList(Customer info)
        {
            personList.Add(info);
        }

        // Check Customer
        public static bool checkCustomer(string id)
        {
            bool isNew = true;
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
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

        // Store Data in File
        public static void saveData()
        {
            string customersPath = "Person.txt";
            StreamWriter file = new StreamWriter(customersPath, false);
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].getRole() == "Customer")
                {
                    Person info = personList[i];
                    file.WriteLine(personList[i].getRole() + "," + info.getName() + "," + info.getID() + "," + info.getContact() + "," + info.getCity() + "," + info.getTotalPerson() + "," + info.getRoomType() + "," + info.getNoOfStay() + "," + info.getCheckIn() + "," + info.getRoomNumber() + "," + info.getBill());
                }
                else if (personList[i].getRole() == "Staff")
                {
                    Person info = personList[i];
                    file.WriteLine(personList[i].getRole() + "," + info.getName() + "," + info.getID() + "," + info.getContact() + "," + info.getCity() + "," + info.getDuty());
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
                        string no_of_stay = splittedRecord[7];
                        string checkIn = splittedRecord[8];
                        int roomNumber = int.Parse(splittedRecord[9]);
                        Customer info = new Customer(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn);
                        addCustomerIntoList(info);
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
                        addStaffMemberIntoList(info);
                    }
                }
                file.Close();
            }
            else
            {
                Interface.FileNotExists();
            }
        }

        // Update Customer
        public static void updateName(string name, int index)
        {
            Person change = personList[index];
            change.setName(name);
        }
        public static void updateTotalPerson(string totalPerson, int index)
        {
            Person change = personList[index];
            change.setTotalPerson(totalPerson);
        }
        public static void updateRoomType(string roomType, int index)
        {
            Person change = personList[index];
            change.setRoomType(roomType);
        }
        public static void updateStayDay(string no_of_stay, int index)
        {
            Person change = personList[index];
            change.setNoOfStay(no_of_stay);
        }

        // Search Customer
        public static void searchCustomerInList(Customer info)
        {
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
                {
                    Person check = personList[x];
                    if (check.getName() == info.getName() && check.getID() == info.getID())
                    {
                        ManagerUI.searchCustomer(check);
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
                ManagerUI.NoCustomerAdded();
            }
            else
            {
                ManagerUI.bookedRooms(personList);
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
            float bill = 0F;
            Person c = personList[index];
            Room r = new Room();
            int stay_days = int.Parse(c.getNoOfStay());
            if (c.getRoomType() == "single" || c.getRoomType() == "Single")
            {
                bill = r.getTypeSingle() * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "double" || c.getRoomType() == "Double")
            {
                bill = r.getTypeDouble() * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "triple" || c.getRoomType() == "Triple")
            {
                bill = r.getTypeTriple() * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "twin" || c.getRoomType() == "Twin")
            {
                bill = r.getTypeTwin() * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "executive" || c.getRoomType() == "Executive")
            {
                bill = r.getTypeExecutive() * stay_days;
                c.setBill(bill);
            }
            else if (c.getRoomType() == "king" || c.getRoomType() == "King")
            {
                bill = r.getTypeKing() * stay_days;
                c.setBill(bill);
            }
        }
        public static void CheckOutFromList(Customer info)
        {
            for (int x = 0; x < personList.Count; x++)
            {
                if (personList[x].getRole() == "Customer")
                {
                    Person check = personList[x];
                    if (check.getName() == info.getName() && check.getID() == info.getID())
                    {
                        ManagerUI.checkout(check);
                        break;
                    }
                }
            }
        }

        // Reviews
        public static void viewReviews()
        {
            int reviewCount = reviewList.Count();
            if (reviewCount == 0)
            {
                CustomerUI.NoReviews();
            }
            else
            {
                for (int x = 0; x < reviewList.Count(); x++)
                {
                    CustomerUI.displayReviewList(reviewList[x]);
                }
            }
        }
        public static void addReviewIntoList(string review)
        {
            reviewList.Add(review);
        }
        public static void customerReview()
        {
            addReviewIntoList(CustomerUI.addReview());
            saveReviewsInFile();
        }

        // Store Reviews in File
        public static void saveReviewsInFile()
        {
            string reviewsPath = "Reviews.txt";
            StreamWriter file = new StreamWriter(reviewsPath, false);
            foreach (string review in reviewList)
            {
                file.WriteLine(review);
            }
            file.Flush();
            file.Close();
        }

        // Reading Review File for Storing Data in Arrays
        public static void loadReviews()
        {
            string reviewsPath = "Reviews.txt";
            if (File.Exists(reviewsPath))
            {
                StreamReader fileVariable = new StreamReader(reviewsPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string review = splittedRecord[0];
                    addReviewIntoList(review);
                }
                fileVariable.Close();
            }
            else
            {
                Interface.FileNotExists();
            }
        }

        // Ratings
        public static void viewRatings()
        {
            int ratingCount = ratingList.Count();
            if (ratingCount == 0)
            {
                CustomerUI.NoRatings();
            }
            else
            {
                for (int x = 0; x < ratingList.Count(); x++)
                {
                    CustomerUI.displayRatingList(ratingList[x]);
                }
            }
        }
        public static void addRatingIntoList(string rating)
        {
            ratingList.Add(rating);
        }
        public static void customerRating()
        {
            CustomerUI.ratingMenu();
            addRatingIntoList(Customer.addRating());
            saveRatingsInFile();
        }
        // Store Ratings in File
        public static void saveRatingsInFile()
        {
            string ratingsPath = "Ratings.txt";
            StreamWriter file = new StreamWriter(ratingsPath, false);
            foreach (string rating in ratingList)
            {
                file.WriteLine(rating);
            }
            file.Flush();
            file.Close();
        }

        // Reading Review File for Storing Data in Arrays
        public static void loadRatings()
        {
            string ratingsPath = "Ratings.txt";
            if (File.Exists(ratingsPath))
            {
                StreamReader fileVariable = new StreamReader(ratingsPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string rating = splittedRecord[0];
                    addRatingIntoList(rating);
                }
                fileVariable.Close();
            }
            else
            {
                Interface.FileNotExists();
            }
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
        public static void addStaffMemberIntoList(StaffMember info)
        {
            personList.Add(info);
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
                StaffMemberUI.NoStaffMember();
            }
            else
            {
                StaffMemberUI.displayStaffMember(personList);
            }
        }
    }
}
