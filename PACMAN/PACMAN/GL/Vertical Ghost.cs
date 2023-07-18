using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN.GL
{
    class Vertical_Ghost:Ghost
    {
        GameDirection direction;
        public Vertical_Ghost(GameDirection direction, char displayCharacter, GameCell startCell) : base(GameObjectType.ENEMY, displayCharacter)
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
            if (CurrentCell.nextCell(GameDirection.Left) == null)
            {

            }
        }
        public override void moveGhost(Ghost Gh)
        {
            if (direction == GameDirection.Up)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Up);

                if (Gh.CurrentCell.nextCell(direction) == Gh.CurrentCell)
                {
                    direction = GameDirection.Down;
                }
            }

            if (direction == GameDirection.Down)
            {
                MovementClass.moveGameObject(Gh, GameDirection.Down);

                if (Gh.CurrentCell.nextCell(direction) == Gh.CurrentCell)
                {
                    direction = GameDirection.Up;
                }
            }
        }
    }
}
