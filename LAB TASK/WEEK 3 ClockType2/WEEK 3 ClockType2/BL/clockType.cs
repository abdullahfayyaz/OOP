using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_3_ClockType2.BL
{
    class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void timeP()
        {
            Console.Write(hours + " " + minutes + " " + seconds);
        }
        public int sec()
        {
            int second = hours * 3600 + minutes * 60 + seconds;
            return second;
        }
    }
}
