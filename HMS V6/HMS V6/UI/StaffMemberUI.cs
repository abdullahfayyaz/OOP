using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.DL;

namespace HMS_V6.UI
{
    class StaffMemberUI
    {
        public static void displayStaffMember(List<StaffMember> staffList)
        {
            Console.WriteLine("Name" + "\t\t" + "ID" + "\t\t\t" + "Contact" + "\t\t" + "City" + "\t\t" + "Role");
            for (int i = 0; i < staffList.Count(); i++)
            {
                StaffMember staff = new StaffMember();
                staff = staffList[i];
                Console.WriteLine(staff.getName() + "\t\t" + staff.getID() + "\t\t" + staff.getContact() + "\t" + staff.getCity() + "\t\t" + staff.getRole());
            }
        }
        public static void NoStaffMember()
        {
            Console.WriteLine("No Staff Member Added");
        }

        // Add Staff Member
        public static void addSatffMember()
        {
        there:
            Interface.printHeader();
            Interface.subMenu("Add Staff Member");
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
                    bool isCheck = StaffMemberDL.checkStaffMember(id);
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
                                displaySatffRoles();
                                string option = Interface.choice();
                                string role = StaffMember.assignRole(option);
                                if(role == null)
                                {
                                    Interface.wrongInput();
                                    Interface.clear();
                                    goto there;
                                }
                                else
                                {
                                    StaffMember info = new StaffMember(name, id, contact, city, role);
                                    StaffMemberDL.addStaffMemberIntoList(info);
                                    StaffMemberDL.saveStaffData();
                                    Console.WriteLine("Staff Member Added");
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
                        Console.WriteLine("Already Exist");
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

        // Select Role
        public static void displaySatffRoles()
        {
            Console.WriteLine();
            Console.WriteLine("*** Assign Role ***");
            Console.WriteLine("1- Hotel receptionist");
            Console.WriteLine("2- Operations manager");
            Console.WriteLine("3- Security manager");
            Console.WriteLine("4- Hotel porter");
            Console.WriteLine("5- Room attendant");
        }

        // Remove Staff Member
        public static void removeStaffMemember()
        {
            Interface.printHeader();
            Interface.subMenu("Remove Staff Member");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            bool valid = Validation.isValid(name);
            if (valid == true)
            {
                Console.Write("Enter CNIC: ");
                string id = Console.ReadLine();
                bool id_valid = Validation.id_check(id);
                if (id_valid == true)
                {
                    StaffMember info = new StaffMember(name, id);
                    int isFound = StaffMemberDL.foundStaffMember(info);
                    if (isFound == -1)
                    {
                        Console.WriteLine("Staff Member Not Found");
                    }
                    else
                    {
                        StaffMemberDL.removeStaffMember(isFound);
                        StaffMemberDL.saveStaffData();
                        Console.WriteLine("Staff Member Removed");
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
    }
}
