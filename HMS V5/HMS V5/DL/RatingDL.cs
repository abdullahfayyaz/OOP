using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V5.BL;

namespace HMS_V5.DL
{
    class RatingDL
    {
        static List<Rating> ratingList = new List<Rating>();
        public static void viewRatings()
        {
            int ratingCount = ratingList.Count();
            if (ratingCount == 0)
            {
                Console.WriteLine("No Ratings");
            }
            else
            {
                for (int x = 0; x < ratingList.Count(); x++)
                {
                    Console.WriteLine("> " + ratingList[x]);
                }
            }
        }
    }
}
