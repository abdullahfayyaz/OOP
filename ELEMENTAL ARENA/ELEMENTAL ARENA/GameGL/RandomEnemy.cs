using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class RandomEnemy : Enemy
    {
        private string flipPosition = "Right";
        private bool flipBool = false;
        private int bulletDelay = 1;
        private int random;
        private int randomDelay;
        private int speed;

        public RandomEnemy(Form gameform, int power, Fury fury, GameDirection direction, Image image, GameCell startCell) : base(gameform, power, GameObjectType.ENEMY, image, direction)
        {
            this.CurrentCell = startCell;
            this.fury = fury;
        }

        public override GameCell move()
        {
            if (this.isEnemyAlive == true)
            {
                if (speed % 1 == 0)
                {
                    if (fury.CurrentCell.X == this.CurrentCell.X)
                    {
                        enemyDirection();
                    }
                    else
                    {
                        movements();
                        GameCell currentCell = this.CurrentCell;
                        GameCell nextCell = currentCell.nextCell(direction);
                        GameObject previousObject = nextCell.CurrentGameObject;
                        this.CurrentCell = nextCell;

                        if (previousObject.GameObjectType == GameObjectType.PLAYER)
                        {
                            fury.decreaseEnergyLevel();
                        }
                        if (currentCell != nextCell)
                        {
                            currentCell.setGameObject(previousObject);
                        }
                        this.setFlipBool(true);
                        speed = 1;
                        return null;
                    }
                }
                speed++;
            }
            return this.CurrentCell;
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
                if (randomDelay % 5 == 0)
                {
                    Random r = new Random();
                    random = r.Next(4);
                }

                if (random == 0)
                {
                    direction = GameDirection.Right;
                    flipPosition = "Right";
                }
                else if (random == 1)
                {
                    direction = GameDirection.Left;
                    flipPosition = "Righ";
                }
                else if (random == 2)
                {
                    direction = GameDirection.Up;
                }
                else if (random == 3)
                {
                    direction = GameDirection.Down;
                }
                randomDelay++;
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
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.AiryLeft;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.AiryRight;
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
                        Image bullet = GameGL.Game.getGameObjectImage('A');
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
