using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN.GL
{

    class Horizontal_Ghost : Ghost
    {
        GameDirection direction;
        public Horizontal_Ghost(GameDirection direction,char displayCharacter, GameCell startCell) : base(GameObjectType.ENEMY, displayCharacter)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
        }
        public override GameCell move(GameDirection direction)
        {
            return this.CurrentCell.nextCell(direction);
        }

        public override void movement()
        {
            if(CurrentCell.nextCell(GameDirection.Left) == null)
            {
               
            }
        }
        public override void moveGhost(Ghost Gh)
        {
            if (direction == GameDirection.Left)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Left);

                if (Gh.CurrentCell.nextCell(direction) == Gh.CurrentCell)
                {
                    direction = GameDirection.Right;
                }
            }

            if (direction == GameDirection.Right)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Right);

                if (Gh.CurrentCell.nextCell(direction) == Gh.CurrentCell)
                {
                    direction = GameDirection.Left;
                }
            }
        }
    }
}
