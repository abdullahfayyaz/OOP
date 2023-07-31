using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class VerticalEnemy : Enemy
    {
        private string flipPosition = "Left";
        private bool flipBool = false;
        private int bulletDelay = 1;
        public VerticalEnemy(Form gameform, int power, Fury fury, GameDirection direction, Image image, GameCell startCell) : base(gameform, power, GameObjectType.ENEMY, image, direction)
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
                    GameObject object2 = nextCell2.CurrentGameObject;
                    GameObject previousObject = nextCell.CurrentGameObject;
                    this.CurrentCell = nextCell;

                    if (currentCell == nextCell)
                    {
                        currentCell.setGameObject(currentCell.CurrentGameObject);
                        movements();
                    }

                    if (currentCell != nextCell || object2.GameObjectType == GameObjectType.PLAYER_BULLET)
                    {
                        currentCell.setGameObject(previousObject);
                        this.setFlipBool(true);
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
            }
            else if (fury.CurrentCell.Y > this.CurrentCell.Y)
            {
                flipPosition = "Right";
            }
        }

        public void movements()
        {
            if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
                flipPosition = "Right";
            }
            else if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
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
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.WateryLeft;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.WateryRight;
            }
        }

        public override void generateBullet()
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
                    Image bullet = GameGL.Game.getGameObjectImage('W');
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
