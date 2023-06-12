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
    class StaffMemberDL
    {
        static private List<StaffMember> staffList = new List<StaffMember>();

        // Add Staff Member
        public static bool checkStaffMember(string id)
        {
            bool isNew = true;
            foreach (StaffMember check in staffList)
            {
                if (id == check.getID())
                {
                    isNew = false;
                    break;
                }
            }
            return isNew;
        }
        public static int foundStaffMember(StaffMember info)
        {
            int indexFound = -1;
            for (int i = 0; i < staffList.Count(); i++)
            {
                if (info.getName() == staffList[i].getName() && info.getID() == staffList[i].getID())
                {
                    indexFound = i;
                    break;
                }
            }
            return indexFound;
        }

        // Remove Staff Member
        public static void removeStaffMember(int index)
        {
            staffList.RemoveAt(index);
        }
        public static void addStaffMemberIntoList(StaffMember info)
        {
            staffList.Add(info);
        }

        // View Staff Member
        public static void viewStaffMember()
        {
            int memberCount = staffList.Count();
            if (memberCount == 0)
            {
                StaffMemberUI.NoStaffMember();
            }
            else
            {
                StaffMemberUI.displayStaffMember(staffList);
            }
        }

        // Store Customer Data in File
        public static void saveStaffData()
        {
            string staffMembersPath = "StaffMembers.txt";
            StreamWriter file = new StreamWriter(staffMembersPath, false);
            for (int i = 0; i < staffList.Count(); i++)
            {
                StaffMember info = new StaffMember();
                info = staffList[i];
                file.WriteLine(info.getName() + "," + info.getID() + "," + info.getContact() + "," + info.getCity() + "," + info.getRole());
            }
            file.Flush();
            file.Close();
        }

        // Reading Customer File for Storing Data in Arrays
        public static void loadSatffData()
        {
            string staffMembersPath = "StaffMembers.txt";
            if (File.Exists(staffMembersPath))
            {
                StreamReader file = new StreamReader(staffMembersPath);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string id = splittedRecord[1];
                    string contact = splittedRecord[2];
                    string city = splittedRecord[3];
                    string role = splittedRecord[4];
                    StaffMember info = new StaffMember(name, id, contact, city, role);
                    addStaffMemberIntoList(info);
                }
                file.Close();
            }
            else
            {
                Interface.FileNotExists();
            }
        }
    }
}
