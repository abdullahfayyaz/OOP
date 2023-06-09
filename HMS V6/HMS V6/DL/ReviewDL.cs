using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_V6.BL;
using HMS_V6.UI;

namespace HMS_V6.DL
{
    class ReviewDL
    {
        static private List<String> reviewList = new List<String>();
        public static void viewReviews()
        {
            int reviewCount = reviewList.Count();
            if (reviewCount == 0)
            {
                ReviewUI.NoReviews();
            }
            else
            {
                for (int x = 0; x < reviewList.Count(); x++)
                {
                    ReviewUI.displayReviewList(reviewList[x]);
                }
            }
        }
    }
}
