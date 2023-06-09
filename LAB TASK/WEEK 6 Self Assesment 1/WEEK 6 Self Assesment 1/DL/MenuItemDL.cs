using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEEK_6_Self_Assesment_1.BL;

namespace WEEK_6_Self_Assesment_1.DL
{
    class MenuItemDL
    {
        static List<MenuItem> itemList = new List<MenuItem>();

        public static void addItemToList(MenuItem item)
        {
            itemList.Add(item);
        }
    }
}
