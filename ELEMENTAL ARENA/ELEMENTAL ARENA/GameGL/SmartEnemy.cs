using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class SmartEnemy : Enemy
    {
        private int bulletDelay = 1;
        private bool flipBool = false;
        private string flipPosition = "Right";
        int speed;
        public SmartEnemy(Form form, int lives, Fury fury, GameDirection direction, Image image, GameCell startCell) : base(form, lives, GameObjectType.ENEMY, image, direction)
        {
            this.CurrentCell = startCell;
            this.fury = fury;
        }

        public override GameCell move()
        {
            if (IsEnemyAlive == true)
            {
                if (speed % 2 == 0)
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
                speed++;
            }
            return this.CurrentCell;
        }

        public void movements()
        {
            double[] distance = new double[4] { 10000, 10000, 10000, 10000 };

            if (this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[0] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Left));
            }

            if (this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[1] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Right));
            }

            if (this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[2] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Up));
            }

            if (this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType != GameObjectType.WALL)
            {
                distance[3] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Down));
            }

            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                if (distance[0] > 4)
                {
                    this.direction = GameDirection.Left;
                    this.setFlipPosition("Left");
                }
            }

            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                if (distance[1] > 4)
                {
                    this.direction = GameDirection.Right;
                    this.setFlipPosition("Right");
                }
            }

            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                {
                    this.direction = GameDirection.Up;
                }
            }

            if (distance[3] <= distance[0] && distance[3] <= distance[1] && distance[3] <= distance[2])
            {
                {
                    this.direction = GameDirection.Down;
                }
            }
        }

        public double calculateDistance(GameCell nextcell)
        {
            return Math.Sqrt(Math.Pow((fury.CurrentCell.X - nextcell.X), 2) + Math.Pow((fury.CurrentCell.Y - nextcell.Y), 2));
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
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.RageLeft;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.RageRight;
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

                    if (bulletDelay % 2 == 0)
                    {
                        this.setFlipBool(false);

                        EnemyBullet b = new EnemyBullet();
                        Image bullet = GameGL.Game.getGameObjectImage('r');
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
