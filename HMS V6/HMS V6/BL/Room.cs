using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class Room
    {
        private const float type_single = 3000;
        private const float type_double = 5000;
        private const float type_triple = 8000;
        private const float type_twin = 6000;
        private const float type_executive = 15000;
        private const float type_king = 10000;
        private const int totalRoom = 200;
        public Room()
        {

        }
        public float getTypeSingle()
        {
            return type_single;
        }
        public float getTypeDouble()
        {
            return type_double;
        }
        public float getTypeTriple()
        {
            return type_triple;
        }
        public float getTypeTwin()
        {
            return type_twin;
        }
        public float getTypeExecutive()
        {
            return type_executive;
        }
        public float getTypeKing()
        {
            return type_king;
        }
        public int getTotalRoom()
        {
            return totalRoom;
        }
    }
}
