using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN.GL
{
    class RandomGhost : Ghost
    {
        int randomDelay;
        int random;
        public RandomGhost( char displayCharacter, GameCell startCell) : base(GameObjectType.ENEMY, displayCharacter)
        {
            
            this.CurrentCell = startCell;
        }
        public override GameCell move(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }

        public override void movement()
        {
            if (CurrentCell.nextCell(GameDirection.Left) == null)
            {

            }
        }

        public override void moveGhost(Ghost Gh)
        {

            if(randomDelay % 5 == 0)
            {
                Random r = new Random();
                random = r.Next(4);
            }

            if (random == 0)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Right);
            }
            else if (random == 1)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Left);
            }
            else if (random == 2)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Up);
            }
            else if (random == 3)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Down);
            }
            randomDelay++;
        }
    }
}
