using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN.GL
{
    class Smart_Ghost : Ghost
    {
        int speed;
        public Smart_Ghost(int speed,char displayCharacter, GameCell startCell) : base(GameObjectType.ENEMY, displayCharacter)
        {
            this.CurrentCell = startCell;
            this.speed = speed;
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

        }

        public void moveGhost(Ghost Gh, GamePacManPlayer Pacman)
        {

            if (speed % 2 == 0)
            {

                if (Pacman.CurrentCell.Y > Gh.CurrentCell.Y)
                {
                    MovementClass.moveGameObject(Gh, GameDirection.Right);
                }
                else if (Pacman.CurrentCell.Y < Gh.CurrentCell.Y)
                {
                    MovementClass.moveGameObject(Gh, GameDirection.Left);
                }
                if (Pacman.CurrentCell.X < Gh.CurrentCell.X)
                {
                    MovementClass.moveGameObject(Gh, GameDirection.Up);
                }
                else if (Pacman.CurrentCell.X > Gh.CurrentCell.X)
                {
                    MovementClass.moveGameObject(Gh, GameDirection.Down);
                }
            }
            speed++;
           
        }
    }
}
