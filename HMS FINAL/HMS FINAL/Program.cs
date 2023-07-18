using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_FINAL.BL;
using HMS_FINAL.DL;
using HMS_FINAL.UI;

namespace HMS_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            string role;
            UserDL.loadUserData();
            PersonDL.loadData();
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
                        if (Extra.exit_app == true)
                        {
                            break;
                        }
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
