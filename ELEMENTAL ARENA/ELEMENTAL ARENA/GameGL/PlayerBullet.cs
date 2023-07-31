using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class PlayerBullet : Bullet
    {
        GameDirection direction;
        private List<Enemy> enemies;

        public PlayerBullet()
        {

        }

        public PlayerBullet(List<Enemy> enemies, GameDirection direction, Image image, GameCell startCell) : base(GameObjectType.PLAYER_BULLET, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;
            this.enemies = enemies;
        }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.KEY && nextCell.CurrentGameObject.GameObjectType != GameObjectType.REWARD && nextCell.CurrentGameObject.GameObjectType != GameObjectType.PORTAL && nextCell.CurrentGameObject.GameObjectType != GameObjectType.PORTAL2 && nextCell.CurrentGameObject.GameObjectType != GameObjectType.MAGIC_LAMP)
            {
                if (getIsActive() == true)
                {
                    GameCell nextCell2 = currentCell.nextWallCell(direction);
                    this.CurrentCell = nextCell;
                    GameObject previousObject = nextCell.CurrentGameObject;
                    GameObject nextObject = nextCell2.CurrentGameObject;

                    if (currentCell != nextCell)
                    {
                        currentCell.setGameObject(Game.getBlankGameObject());

                    }
                    else if (currentCell == nextCell)
                    {
                        if (nextObject.GameObjectType == GameObjectType.ENEMY)
                        {
                            foreach (Enemy enemy in enemies)
                            {
                                GameCell next = enemy.CurrentCell.nextWallCell(GameDirection.Left);
                                GameObject obj = next.CurrentGameObject;
                                GameCell next2 = enemy.CurrentCell.nextWallCell(GameDirection.Right);
                                GameObject obj2 = next2.CurrentGameObject;

                                if (obj.GameObjectType == GameObjectType.PLAYER_BULLET)
                                {
                                    enemy.decreasePower();
                                }
                                else if (obj2.GameObjectType == GameObjectType.PLAYER_BULLET)
                                {
                                    enemy.decreasePower();
                                }
                            }
                        }
                        currentCell.setGameObject(Game.getBlankGameObject());
                        this.setIsActive(false);
                    }
                    return nextCell;
                }
            }
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.KEY ||
                     nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD ||
                     nextCell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL ||
                     nextCell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL2 ||
                     nextCell.CurrentGameObject.GameObjectType == GameObjectType.MAGIC_LAMP)
            {
                this.setIsActive(false);
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            return null;
        }
    }
}
