using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_V6.BL
{
    class Room
    {
        private int type_single = 3000;
        private int type_double = 5000;
        private int type_triple = 8000;
        private int type_twin = 6000;
        private int type_executive = 15000;
        private int type_king = 10000;
        public Room()
        {

        }
        public int getTypeSingle()
        {
            return type_single;
        }
        public int getTypeDouble()
        {
            return type_double;
        }
        public int getTypeTriple()
        {
            return type_triple;
        }
        public int getTypeTwin()
        {
            return type_twin;
        }
        public int getTypeExecutive()
        {
            return type_executive;
        }
        public int getTypeKing()
        {
            return type_king;
        }
    }
}
