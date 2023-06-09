using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.UI
{
    class ReviewUI
    {
        public static void NoReviews()
        {
            Console.WriteLine("No Reviews");
        }
        public static void displayReviewList(string review)
        {
            Console.WriteLine("> " + review);
        }
    }
}
