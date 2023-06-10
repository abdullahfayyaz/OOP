using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Week_6
{
    class Cell
    {
        public char value;
        public int X;
        public int Y;
        public Cell(char value, int X, int Y)
        {
            this.value = value;
            this.X = X;
            this.Y = Y;
        }

        public char get_value()
        {
            return value;
        }

        public void setValue(char value)
        {
            this.value = value;
        }

        public int getvalueofX()
        {
            return X;
        }

        public int getvalueofY()
        {
            return Y;
        }

        public bool presenceofpackman()
        {
            if (value == 'P')
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool presenceofGhost(char ghostCharacter)
        {
            if (value == ghostCharacter)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
