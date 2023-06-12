﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.DL;
using HMS_V6.UI;

namespace HMS_V6
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            string role = "";
            int roomCount = 1;
            bool exit_app = false;
            UserDL.loadUserData();
            CustomerDL.loadCustomerData(ref roomCount);
            CustomerDL.loadRatings();
            CustomerDL.loadReviews();
            StaffMemberDL.loadSatffData();
            do
            {
                Interface.printHeader();
                UserUI.loginSignup();
                option = Interface.choice();
                if (option == "1")
                {
                    role = UserUI.login();
                    if (role == "manager")
                    {
                        ManagerUI.managerInterface(ref roomCount, ref exit_app);
                        if (exit_app == true)
                        {
                            break;
                        }
                    }
                    else if (role == "customer")
                    {
                        CustomerUI.customerInterface(ref roomCount, ref exit_app);
                    }
                    else
                    {
                        UserUI.Invalid();
                        Interface.clear();
                    }
                }
                else if (option == "2")
                {
                    UserUI.signUp();
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Interface.wrongInput();
                    Interface.clear();
                }
            }
            while (option != "3");
        }
    }
}
