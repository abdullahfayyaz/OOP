using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_7_Challenge_2.BL
{
    class Bicycle
    {
        private int cadence;
        private int gear;
        private int speed;
        public Bicycle(int cadence, int speed, int gear)
        {
            this.cadence = cadence;
            this.speed = speed;
            this.gear = gear;
        }
        public void setCadence(int cardence)
        {

        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void applyBreak(int decrement)
        {

        }
        public void speedUp(int increment)
        {

        }
    }
    class MountainBike : Bicycle
    {
        private int seatHeight;
        public MountainBike(int seatHeight, int cadence, int speed, int gear) : base (cadence, speed, gear)
        {
            this.seatHeight = seatHeight;
        }
        public void setSeatHeight(int seatHeight)
        {

        }
    }
}
