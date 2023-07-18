using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_FINAL.BL;
using HMS_FINAL.DL;

namespace HMS_FINAL.UI
{
    class StaffMemberUI
    {
        public static void displayStaffMember(List<Person> personList)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name" + "\t\t" + "ID" + "\t\t\t" + "Contact" + "\t\t" + "City" + "\t\t" + "Duty");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].getRole() == "Staff")
                {
                    Console.WriteLine(personList[i].getName() + "\t\t" + personList[i].getID() + "\t\t" + personList[i].getContact() + "\t" + personList[i].getCity() + "\t\t" + personList[i].getDuty());
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void NoStaffMember()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("No Staff Member Added");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Add Staff Member
        public static void addSatffMember()
        {
        there:
            Interface.printHeader();
            Interface.subMenu("Add Staff Member");
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
                    bool isCheck = PersonDL.checkStaffMember(id);
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
                                displaySatffRoles();
                                string option = Interface.choice();
                                string role = StaffMember.assignRole(option);
                                if (role == null)
                                {
                                    Interface.wrongInput();
                                    Interface.clear();
                                    goto there;
                                }
                                else
                                {
                                    StaffMember info = new StaffMember(name, id, contact, city, role);
                                    PersonDL.addPersonIntoList(info);
                                    PersonDL.saveData();
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Staff Member Added");
                                    Console.ForegroundColor = ConsoleColor.White;
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

        // Select Role
        public static void displaySatffRoles()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** Assign Role ***");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1- Hotel receptionist");
            Console.WriteLine("2- Operations manager");
            Console.WriteLine("3- Security manager");
            Console.WriteLine("4- Hotel porter");
            Console.WriteLine("5- Room attendant");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Remove Staff Member
        public static void removeStaffMemember()
        {
            Interface.printHeader();
            Interface.subMenu("Remove Staff Member");
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
                bool id_valid = Validation.id_check(id);
                if (id_valid == true)
                {
                    StaffMember info = new StaffMember(name, id);
                    int isFound = PersonDL.foundStaffMember(info);
                    if (isFound == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Staff Member Not Found");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        PersonDL.removePerson(isFound);
                        PersonDL.saveData();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Staff Member Removed");
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
        }
    }
}
