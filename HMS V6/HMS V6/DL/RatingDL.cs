using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.UI;

namespace HMS_V6.DL
{
    class RatingDL
    {
        static private List<float> ratingList = new List<float>();
        public static void viewRatings()
        {
            int ratingCount = ratingList.Count();
            if (ratingCount == 0)
            {
                RatingUI.NoRatings();
            }
            else
            {
                for (int x = 0; x < ratingList.Count(); x++)
                {
                    RatingUI.displayRatingList(ratingList[x]);
                }
            }
        }
    }
}
