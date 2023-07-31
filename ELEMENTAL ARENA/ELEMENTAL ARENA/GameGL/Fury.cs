using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class Fury : GameObject
    {
        ProgressBar furyHealthBar;
        Form gameForm;
        private bool isFuryAlive = true;
        private bool isPortalOpen = false;
        private bool magicLamp = false;
        private bool isClaimHealth = false;
        private int energyLevel;
        private int scores = 0;
        private int key = 0;
        private string flipPosition = "Right";
        private bool flipBool = false;
        private int jumpHeight;
        int bulletDelay = 1;
        public Fury(Form gameForm, Image image, GameCell startCell, int scores, int energyLevel) : base(GameObjectType.PLAYER, image)
        {
            this.gameForm = gameForm;
            this.CurrentCell = startCell;
            this.scores = scores;
            this.energyLevel = energyLevel;
            furyHealthBar = new ProgressBar();
            furyHealthBar.Size = new Size(30, 7);
            furyHealthBar.ForeColor = Color.Green;
            furyHealthBar.BackColor = Color.Black;
            furyHealthBar.Style = ProgressBarStyle.Continuous;
            gameForm.Controls.Add(furyHealthBar);
        }

        public int EnergyLevel { get => energyLevel; set => energyLevel = value; }

        public bool IsFuryAlive { get => isFuryAlive; set => isFuryAlive = value; }

        public bool IsPortalOpen { get => isPortalOpen; set => isPortalOpen = value; }

        public bool MagicLamp { get => magicLamp; set => magicLamp = value; }

        public bool IsClaimHealth { get => isClaimHealth; set => isClaimHealth = value; }

        public void decreaseEnergyLevel()
        {
            energyLevel = energyLevel - 5;
        }

        public void setBarValue()
        {
            furyHealthBar.Value = energyLevel;
        }

        public void setBarPosition()
        {
            furyHealthBar.Top = this.CurrentCell.X * 55;
            furyHealthBar.Left = this.CurrentCell.Y * 55;
        }

        public GameCell move(GameDirection direction)
        {
            if (isFuryAlive == true)
            {
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(direction);
                addScores(nextCell);
                claimKey(nextCell);
                Portal(nextCell);
                CheckMagicLamp(nextCell);
                increaseHealth(nextCell);
                this.CurrentCell = nextCell;
                if (currentCell != nextCell)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());

                }
                return nextCell;
            }
            return null;
        }

        private void addScores(GameCell nextCell)
        {
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                scores += 10;
            }
        }

        private void claimKey(GameCell nextCell)
        {
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.KEY)
            {
                key++;
            }
        }

        private void Portal(GameCell nextCell)
        {
            {
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL || nextCell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL2)
                {
                    isPortalOpen = true;
                }
            }
        }

        private void CheckMagicLamp(GameCell nextCell)
        {
            {
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.MAGIC_LAMP)
                {
                    magicLamp = true;
                }
            }
        }

        private void increaseHealth(GameCell nextCell)
        {
            {
                if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.HEALTH)
                {
                    isClaimHealth = true;
                }
            }
        }

        public int getScores()
        {
            return scores;
        }

        public int getKey()
        {
            return key;
        }

        public int getJumpHeight()
        {
            return jumpHeight;
        }

        public void setJumpHeight(int height)
        {
            this.jumpHeight = height;
        }

        public void decreaseHieght()
        {
            jumpHeight--;
        }

        public string getFlipPosition()
        {
            return flipPosition;
        }

        public void setFlipPosition(string position)
        {
            flipPosition = position;
        }

        public bool getFlipBool()
        {
            return flipBool;
        }

        public void setFlipBool(bool flip)
        {
            flipBool = flip;
        }

        public void flipFury()
        {
            if (flipPosition == "Left")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.FuryLeft;
            }
            else if (flipPosition == "Right")
            {
                this.CurrentCell.PictureBox.Image = ELEMENTAL_ARENA.Properties.Resources.FuryRight;
            }
        }


        public void generateBullet()
        {
            if (bulletDelay % 1 == 0)
            {
                PlayerBullet b = new PlayerBullet();
                Image bullet = GameGL.Game.getGameObjectImage('Z');
                GameCell startBullet = new GameCell();
                if (this.getFlipPosition() == "Right")
                {
                    GameCell next = this.CurrentCell.nextWallCell(GameDirection.Right);
                    if (next.CurrentGameObject.GameObjectType == GameObjectType.NONE)
                    {
                        startBullet = this.CurrentCell.nextCell(GameDirection.Right);
                        b = new PlayerBullet(Game.enemies, GameDirection.Right, bullet, startBullet);
                        b.setIsActive(true);
                        Game.bullets.Add(b);
                    }

                }
                else if (this.getFlipPosition() == "Left")
                {
                    GameCell next = this.CurrentCell.nextWallCell(GameDirection.Left);
                    if (next.CurrentGameObject.GameObjectType == GameObjectType.NONE)
                    {
                        startBullet = this.CurrentCell.nextCell(GameDirection.Left);
                        b = new PlayerBullet(Game.enemies, GameDirection.Left, bullet, startBullet);
                        b.setIsActive(true);
                        Game.bullets.Add(b);
                    }

                }
            }
            bulletDelay++;


        }

    }
}
