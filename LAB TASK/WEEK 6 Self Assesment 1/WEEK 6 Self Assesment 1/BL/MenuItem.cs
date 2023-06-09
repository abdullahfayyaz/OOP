using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_6_Self_Assesment_1.BL
{
    class MenuItem
    {
        public string itemName;
        public string itemType;
        public float itemPrice;
        public MenuItem()
        {

        }
        public MenuItem(string itemName, string itemType, float itemPrice)
        {
            this.itemName = itemName;
            this.itemType = itemType;
            this.itemPrice = itemPrice;
        }
    }
}
