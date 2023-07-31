using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    abstract class Enemy : GameObject
    {
        protected ProgressBar enemyHealthBar = new ProgressBar();
        protected int power;
        protected Fury fury;
        protected bool isEnemyAlive;
        Form gameform;
        protected GameDirection direction;
        public Enemy(Form gameform, int power, GameObjectType gameObjectType, Image image, GameDirection direction) : base(GameObjectType.ENEMY, image)
        {
            this.power = power;
            this.gameform = gameform;
            this.direction = direction;
            enemyHealthBar = new ProgressBar();
            enemyHealthBar.Size = new Size(30, 7);
            enemyHealthBar.ForeColor = Color.Red;
            enemyHealthBar.BackColor = Color.Black;
            enemyHealthBar.Style = ProgressBarStyle.Continuous;
            isEnemyAlive = true;
            gameform.Controls.Add(enemyHealthBar);
        }
        public abstract GameCell move();

        public abstract string getFlipPosition();

        public abstract void generateBullet();

        public abstract void setFlipPosition(string position);

        public abstract bool getFlipBool();

        public abstract void setFlipBool(bool flip);

        public abstract void flipPoison();

        public int Power { get => power; set => power = value; }

        public bool IsEnemyAlive { get => isEnemyAlive; set => isEnemyAlive = value; }

        public void increasePower()
        {
            power = power + 5;
        }

        public void decreasePower()
        {
            power = power - 5;
        }

        public ProgressBar getBar()
        {
            return enemyHealthBar;
        }

        public void setBarValue()
        {
               enemyHealthBar.Value = power;
        }

        public void setBarPosition()
        {
            enemyHealthBar.Top = this.CurrentCell.X * 55;
            enemyHealthBar.Left = this.CurrentCell.Y * 55;
        }
    }
}
