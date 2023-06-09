using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V5.BL;

namespace HMS_V5.DL
{
    class ReviewDL
    {
        static List<Review> reviewList = new List<Review>();
        public static void viewReviews()
        {
            int reviewCount = reviewList.Count();
            if (reviewCount == 0)
            {
                
            }
            else
            {
                for (int x = 0; x < reviewList.Count(); x++)
                {
                    Console.WriteLine("> " + reviewList[x]);
                }
            }
        }
    }
}
