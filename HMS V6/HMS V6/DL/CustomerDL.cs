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
    class CustomerDL
    {
        static private List<Customer> customerList = new List<Customer>();
        static private List<String> reviewList = new List<String>();
        static private List<String> ratingList = new List<String>();

        // Add Customer
        public static bool checkCustomer(string id)
        {
            bool isNew = true;
            foreach (Customer check in customerList)
            {
                if (id == check.getID())
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
                if (info.getName() == customerList[i].getName() && info.getID() == customerList[i].getID())
                {
                    indexFound = i;
                    break;
                }
            }
            return indexFound;
        }

        // Store Customer Data in File
        public static void saveCustomerData()
        {
            string customersPath = "Customers.txt";
            StreamWriter file = new StreamWriter(customersPath, false);
            for (int i = 0; i < customerList.Count(); i++)
            {
                Customer info = new Customer();
                info = customerList[i];
                file.WriteLine(info.getName() + "," + info.getID() + "," + info.getContact() + "," + info.getCity() + "," + info.getTotalPerson() + "," + info.getRoomType() + "," + info.getNoOfStay() + "," + info.getCheckIn() + "," + info.getRoomNumber());
            }
            file.Flush();
            file.Close();
        }

        // Reading Customer File for Storing Data in Arrays
        public static void loadCustomerData(ref int roomCount)
        {
            string customersPath = "Customers.txt";
            if (File.Exists(customersPath))
            {
                StreamReader file = new StreamReader(customersPath);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string id = splittedRecord[1];
                    string contact = splittedRecord[2];
                    string city = splittedRecord[3];
                    string totalPerson = splittedRecord[4];
                    string roomType = splittedRecord[5];
                    string no_of_stay = splittedRecord[6];
                    string checkIn = splittedRecord[7];
                    int roomNumber = int.Parse(splittedRecord[8]);
                    Customer info = new Customer(name, id, contact, city, totalPerson, roomType, roomNumber, no_of_stay, checkIn);
                    addCustomerIntoList(info);
                    roomCount++;
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
            Customer change = new Customer();
            change = customerList[index];
            change.setName(name);
        }
        public static void updateTotalPerson(string totalPerson, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.setTotalPerson(totalPerson);
        }
        public static void updateRoomType(string roomType, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.setRoomType(roomType);
        }
        public static void updateStayDay(string no_of_stay, int index)
        {
            Customer change = new Customer();
            change = customerList[index];
            change.setNoOfStay(no_of_stay);
        }

        // Search Customer
        public static void searchCustomerInList(Customer info)
        {
            foreach (Customer check in customerList)
            {
                if (check.getName() == info.getName() && check.getID() == info.getID())
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
        public static void viewBookedRooms()
        {
            int customerCount = customerList.Count();
            if (customerCount == 0)
            {
                ManagerUI.NoCustomerAdded();
            }
            else
            {
                ManagerUI.bookedRooms(customerList);
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
        public static void checkoutBill(int index)
        {
            float bill = 0F;
            Customer c = new Customer();
            Room r = new Room();
            c = customerList[index];
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
            foreach (Customer check in customerList)
            {
                if (check.getName() == info.getName() && check.getID() == info.getID())
                {
                    ManagerUI.checkout(check);
                    break;
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
    }
}
