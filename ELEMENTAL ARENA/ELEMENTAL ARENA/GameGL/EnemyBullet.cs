using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELEMENTAL_ARENA.GameGL
{
    class EnemyBullet : Bullet
    {
        GameDirection direction;
        Fury fury;

        public EnemyBullet(Fury fury, GameDirection direction, Image image, GameCell startCell) : base(GameObjectType.ENEMY_BULLET, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.fury = fury;

        }
        public EnemyBullet()
        {

        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY && nextCell.CurrentGameObject.GameObjectType != GameObjectType.REWARD)
            {
                if (getIsActive() == true)
                {
                    GameCell nextCell2 = currentCell.nextWallCell(direction);
                    this.CurrentCell = nextCell;
                    GameObject nextObject = nextCell2.CurrentGameObject;


                    if (currentCell != nextCell)
                    {
                        currentCell.setGameObject(Game.getBlankGameObject());
                    }
                    else if (currentCell == nextCell)
                    {
                        if (nextObject.GameObjectType == GameObjectType.PLAYER)
                        {
                            fury.decreaseEnergyLevel();
                        }
                        currentCell.setGameObject(Game.getBlankGameObject());

                        this.setIsActive(false);

                    }
                    return nextCell;
                }
            }
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.KEY || nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                this.setIsActive(false);
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            return null;
        }
    }
}
