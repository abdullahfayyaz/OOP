using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.UI
{
    class RatingUI
    {
        public static void NoRatings()
        {
            Console.WriteLine("No Ratings");
        }
        public static void displayRatingList(float rating)
        {
            Console.WriteLine("> " + rating);
        }
    }
}
