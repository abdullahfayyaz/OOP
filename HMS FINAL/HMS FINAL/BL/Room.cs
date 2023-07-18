using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_FINAL.BL
{
    class Room
    {
        private float type_single = 3000;
        private float type_double = 5000;
        private float type_triple = 8000;
        private float type_twin = 6000;
        private float type_executive = 15000;
        private float type_king = 10000;
        private int totalRoom = 200;
        public static int roomCount = 1;
        public Room()
        {

        }
        public float TypeSingle { get => type_single; }
        public float TypeDouble { get => type_double; }
        public float TypeTriple { get => type_triple; }
        public float TypeTwin { get => type_twin; }
        public float TypeExecutive { get => type_executive; }
        public float TypeKing { get => type_king; }
        public int TotalRoom { get => totalRoom; }
    }
}
