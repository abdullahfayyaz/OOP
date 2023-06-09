using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_7_Challenge_1.BL
{
    class FireTruck
    {
        List<Person> person = new List<Person>();
        public Ladder L;
        public HosePipe H;
        public FireTruck()
        {
            this.L = new Ladder();
        }
        public void setPipe(HosePipe obj)
        {
            this.H = obj;
        }
    }
    class Ladder
    {
        public float length;
        public string colour;
    }
    class HosePipe
    {
        public string material;
        public string shape;
        public float diameter;
        public float waterFlowRate;
    }
}
