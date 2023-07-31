using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class HorizontalEnemy : Enemy
    {
        private string flipPosition = "Right";
        private bool flipBool = false;
        private int bulletDelay = 1;

        public HorizontalEnemy(Form gameform, int power, Fury fury, GameDirection direction, Image image, GameCell startCell) : base(gameform, power, GameObjectType.ENEMY, image, direction)
        {
            this.CurrentCell = startCell;
            this.fury = fury;
        }

        public override GameCell move()
        {
            if (this.isEnemyAlive == true)
            {
                if (fury.CurrentCell.X != this.CurrentCell.X)
                { 
                    GameCell currentCell = this.CurrentCell;
                    GameCell nextCell = currentCell.nextCell(direction);
                    GameCell nextCell2 = currentCell.nextWallCell(direction);
                    GameObject previousObject = nextCell.CurrentGameObject;
                    this.CurrentCell = nextCell;
                    GameCell downCell = nextCell.nextWallCell(GameDirection.Down);

                    if (currentCell != nextCell)
                    {
                        currentCell.setGameObject(previousObject);
                        if (downCell.CurrentGameObject.GameObjectType == GameObjectType.VERTICAL_WALL)
                        {
                            movements();
                        }
                        this.setFlipBool(true);

                    }

                    if (nextCell2.CurrentGameObject.GameObjectType == GameObjectType.PLAYER_BULLET)
                    {
                        this.decreasePower();
                    }

                }
                else if (fury.CurrentCell.X == this.CurrentCell.X)
                {
                    enemyDirection();
                }
            }
            return null;
        }

        private void enemyDirection()
        {
            if (fury.CurrentCell.Y < this.CurrentCell.Y)
            {
                flipPosition = "Left";
                direction = GameDirection.Left;
            }
            else if (fury.CurrentCell.Y > this.CurrentCell.Y)
            {
                flipPosition = "Right";
                direction = GameDirection.Right;
            }
        }

        public void movements()
        {
            if (direction == GameDirection.Left)
            {
                direction = GameDirection.Right;
                flipPosition = "Right";
            }
            else if (direction == GameDirection.Right)
            {
                direction = GameDirection.Left;
                flipPosition = "Left";
            }
        }

        public override string getFlipPosition()
        {
            return flipPosition;
        }

        public override void setFlipPosition(string position)
        {
            flipPosition = position;
        }

        public override bool getFlipBool()
        {
            return flipBool;
        }

        public override void setFlipBool(bool flip)
        {
            flipBool = flip;
        }

        public override void flipPoison()
        {
            if (flipPosition == "Left")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.PoisonLeft;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.PoisonRight;
            }
        }

        public override void generateBullet()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextWallCell(direction);

            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {
                if (fury.CurrentCell.X == this.CurrentCell.X)
                {
                    if (bulletDelay == 2)
                    {
                        this.setFlipBool(true);
                    }

                    if (bulletDelay % 3 == 0)
                    {
                        this.setFlipBool(false);
                        EnemyBullet b = new EnemyBullet();
                        Image bullet = GameGL.Game.getGameObjectImage('P');
                        GameCell startBullet = new GameCell();
                        if (this.getFlipPosition() == "Right")
                        {
                            startBullet = this.CurrentCell.nextCell(GameDirection.Right);
                            b = new EnemyBullet(fury, GameDirection.Right, bullet, startBullet);
                        }
                        else if (this.getFlipPosition() == "Left")
                        {
                            startBullet = this.CurrentCell.nextCell(GameDirection.Left);
                            b = new EnemyBullet(fury, GameDirection.Left, bullet, startBullet);
                        }
                        b.setIsActive(true);
                        Game.enemyBullets.Add(b);
                    }
                    bulletDelay++;
                }
                else
                {
                    bulletDelay = 1;
                }
            }
        }
    }
}
