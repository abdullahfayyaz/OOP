using System;
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
            string option;
            string role;
            UserDL.loadUserData();
            PersonDL.loadData();
            PersonDL.loadRatings();
            PersonDL.loadReviews();
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
                        ManagerUI.managerInterface();
                        if (Extra.exit_app == true)
                        {
                            break;
                        }
                    }
                    else if (role == "customer")
                    {
                        CustomerUI.customerInterface();
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
