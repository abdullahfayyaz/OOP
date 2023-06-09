using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_7_Inheritance.BL
{
    class Student
    {
        public string name;
        public string session;
        public bool isDayScholar;
        public int EntryTestMarks;
        public int HSMarks;
        public double calculateMerit()
        {
            double merit = 0.0;
            return merit;
        }
    }
    class Hostelite : Student
    {
        public int RoomNumber;
        public bool isFridgeAvailable;
        public bool isInternetAvailable;
        public int getHostelFee()
        {
            int fee = 0;
            return fee;
        }
    }
    class DayScholar : Student
    {
        public string pickUpPoint;
        public int busNo;
        public int getBusFee()
        {
            int fee = 0;
            return fee;
        }
    }
}
