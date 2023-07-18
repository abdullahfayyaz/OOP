using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HMS_FINALIZED.BL
{
    class Validation
    {
        public static bool password_check(string password)
        {
            // Define the password requirements (at least 8 characters, containing uppercase, lowercase, numeric, and special characters)
            bool hasMinimumLength = password.Length >= 8;
            bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
            bool hasLowercase = Regex.IsMatch(password, "[a-z]");
            bool hasNumeric = Regex.IsMatch(password, "[0-9]");
            bool hasSpecialCharacters = Regex.IsMatch(password, "[#$%&]");

            // Check if the entered password meets the requirements
            bool isValid = hasMinimumLength && hasUppercase && hasLowercase && hasNumeric && hasSpecialCharacters;

            if (isValid)
            {
                // Password is valid
                return true;
            }
            else
            {
                // Password is invalid
                return false;
            }
        }
        public static bool userName_check(string name)
        {
            string pattern = "^[a-zA-Z0-9_]{4,16}$";

            // Check if the entered username matches the pattern
            bool isValid = Regex.IsMatch(name, pattern);

            if (isValid)
            {
                // Username is valid
                return true;
            }
            else
            {
                // Username is invalid
                return false;
            }
        }
        public static bool isValid(string name)
        {
            // Define the name requirements (at least 3 characters, first letter capitalized, remaining letters lowercase)
            string pattern = @"^[A-Z][a-z]{2,}$";

            // Check if the entered name matches the pattern
            bool isValid = Regex.IsMatch(name, pattern);

            return isValid;
        }
        public static bool id_check(string id)
        {
            bool flag = false;
            int x = 0;
            while (x < id.Length)
            {
                if (x < 5)
                {
                    if (id[x] > 47 && id[x] < 58)
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 4 && x < 6)
                {
                    if (id[5] == '-')
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 5 && x < 13)
                {
                    if ((id[x] > 47 && id[x] < 58))
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 12 && x < 14)
                {
                    if (id[13] == '-')
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else if (x > 13 && x < 15)
                {
                    if ((id[x] > 47 && id[x] < 58))
                    {
                        x++;
                        if (x == 15)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        x++;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static bool check_person(string totalPerson)
        {
            bool flag = false;
            if (totalPerson == "1" || totalPerson == "2" || totalPerson == "3" || totalPerson == "4" || totalPerson == "5")
            {
                flag = true;
            }
            return flag;
        }
        public static bool contact_check(string contact)
        {
            bool flag = false;
            int i = 0;
            while (i < contact.Length)
            {
                if (i == 0)
                {
                    if (contact[0] == '0')
                    {
                        i++;
                        if (i == 11)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (contact[i] > 47 && contact[i] < 58)
                {
                    i++;
                    if (i == 11)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static bool check_stay(string stay)
        {
            bool flag = false;
            if (stay == "1")
            {
                flag = true;
            }
            else if (stay == "2")
            {
                flag = true;
            }
            else if (stay == "3")
            {
                flag = true;
            }
            else if (stay == "4")
            {
                flag = true;
            }
            else if (stay == "5")
            {
                flag = true;
            }
            else if (stay == "6")
            {
                flag = true;
            }
            else if (stay == "7")
            {
                flag = true;
            }
            else if (stay == "8")
            {
                flag = true;
            }
            else if (stay == "9")
            {
                flag = true;
            }
            else if (stay == "10")
            {
                flag = true;
            }
            else if (stay == "11")
            {
                flag = true;
            }
            else if (stay == "12")
            {
                flag = true;
            }
            else if (stay == "13")
            {
                flag = true;
            }
            else if (stay == "14")
            {
                flag = true;
            }
            else if (stay == "15")
            {
                flag = true;
            }
            else if (stay == "16")
            {
                flag = true;
            }
            else if (stay == "17")
            {
                flag = true;
            }
            else if (stay == "18")
            {
                flag = true;
            }
            else if (stay == "19")
            {
                flag = true;
            }
            else if (stay == "20")
            {
                flag = true;
            }
            else if (stay == "21")
            {
                flag = true;
            }
            else if (stay == "22")
            {
                flag = true;
            }
            else if (stay == "23")
            {
                flag = true;
            }
            else if (stay == "24")
            {
                flag = true;
            }
            else if (stay == "25")
            {
                flag = true;
            }
            else if (stay == "26")
            {
                flag = true;
            }
            else if (stay == "27")
            {
                flag = true;
            }
            else if (stay == "28")
            {
                flag = true;
            }
            else if (stay == "29")
            {
                flag = true;
            }
            else if (stay == "30")
            {
                flag = true;
            }
            else if (stay == "31")
            {
                flag = true;
            }
            return flag;
        }
        public static bool check_room_type(string room)
        {
            bool flag = false;
            if (room == "Single" || room == "single")
            {
                flag = true;
            }
            else if (room == "Double" || room == "double")
            {
                flag = true;
            }
            else if (room == "Triple" || room == "triple")
            {
                flag = true;
            }
            else if (room == "Twin" || room == "twin")
            {
                flag = true;
            }
            else if (room == "Executive" || room == "executive")
            {
                flag = true;
            }
            else if (room == "King" || room == "king")
            {
                flag = true;
            }
            return flag;
        }
        public static bool date_check(string date)
        {
            bool flag = false;
            int x = 0;
            while (x < date.Length)
            {
                if (x == 0)
                {
                    if (date[x] > 47 && date[x] < 52)
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 1)
                {
                    if (date[0] == '0')
                    {
                        if (date[x] > 48 && date[x] < 58)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (date[0] == '1' || date[0] == '2')
                    {
                        if (date[x] > 47 && date[x] < 58)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (date[0] == '3')
                    {
                        if (date[x] > 47 && date[x] < 50)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 2)
                {
                    if (date[2] == '/')
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 3)
                {
                    if (date[x] > 47 && date[x] < 50)
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x == 4)
                {
                    if (date[3] == '0')
                    {
                        if (date[x] > 48 && date[x] < 58)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (date[3] == '1')
                    {
                        if (date[x] > 47 && date[x] < 51)
                        {
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (x == 5)
                {
                    if (date[5] == '/')
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (x > 5 && x < 10)
                {
                    if (date[x] > 47 && date[x] < 58)
                    {
                        x++;
                        if (x == 10)
                        {
                            flag = true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
