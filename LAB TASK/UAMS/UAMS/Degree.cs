using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Degree
    {
        public string Name;
        public int Duration;
        public int Seats;
        public Degree()
        {

        }
        public Degree(string Name,int Duration,int Seats)
        {
            this.Name = Name;
            this.Duration = Duration;
            this.Seats = Seats;
        }
    }
}
