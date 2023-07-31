using ELEMENTAL_ARENA.GameGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace ELEMENTAL_ARENA
{
    public partial class GameForm : Form
    {
        GameGrid grid;
        Fury fury;
        HorizontalEnemy poison;
        HorizontalEnemy poison2;

        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 14, 28);

            Image furyImage = GameGL.Game.getGameObjectImage('F');
            GameCell startCell = grid.getCell(12, 3);
            fury = new Fury(this, furyImage, startCell, 0, 100);

            Image poisonImage = GameGL.Game.getGameObjectImage('H');
            GameCell poisonStartCell = grid.getCell(8, 3);
            poison = new HorizontalEnemy(this, 100, fury, GameDirection.Left, poisonImage, poisonStartCell);

            Image poison2Image = GameGL.Game.getGameObjectImage('H');
            GameCell poison2StartCell = grid.getCell(4, 24);
            poison2 = new HorizontalEnemy(this, 100, fury, GameDirection.Left, poison2Image, poison2StartCell);


            Game.enemies.Add(poison);
            Game.enemies.Add(poison2);

            printMaze(grid);
        }

        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ScoreLabel.Text = Convert.ToString(fury.getScores());
            KeyLabel.Text = Convert.ToString(fury.getKey());
     
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                fury.move(GameDirection.Left);
                if (fury.getFlipPosition() == "Right")
                {
                    fury.setFlipPosition("Left");
                }
                fury.setFlipBool(true);
            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                fury.move(GameDirection.Right);
                if (fury.getFlipPosition() == "Left")
                {
                    fury.setFlipPosition("Right");
                }
                fury.setFlipBool(true);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if (fury.CurrentCell.nextWallCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.WALL || fury.CurrentCell.nextWallCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.VERTICAL_WALL)
                {
                    fury.setJumpHeight(2);
                }
            }

            if (Keyboard.IsKeyPressed(Key.Space))
            {
                fury.generateBullet();
            }

            if (fury.getJumpHeight() > 0)
            {
                fury.move(GameDirection.Up);
                fury.setFlipBool(true);
                fury.decreaseHieght();
            }
            else if (fury.CurrentCell.nextWallCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.NONE)
            {
                fury.move(GameDirection.Down);
                fury.setFlipBool(true);
            }

            if (fury.getFlipBool() == true)
            {
                fury.flipFury();
                fury.setFlipBool(false);
            }

            if(fury.IsClaimHealth == true)
            {
                fury.EnergyLevel = 100;
                fury.setBarValue();
                fury.IsClaimHealth = false;
            }

            if(fury.IsPortalOpen == true)
            {
                GameTimer.Enabled = false;
                MessageBox.Show("NEXT LEVEL", "LEVEL 1 COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GameForm2 level2 = new GameForm2();
                level2.ShowDialog();
                this.Close();
            }

            fury.setBarValue();
            fury.setBarPosition();

            foreach (Enemy enemy in Game.enemies)
            {
                enemy.move();
                if (enemy.getFlipBool() == true)
                {
                    enemy.setFlipBool(false);
                }
                enemy.flipPoison();
                enemy.generateBullet();

                enemy.setBarValue();
                enemy.setBarPosition();

                if (enemy.Power == 0)
                {
                    enemy.Power = 100;
                    enemy.setBarValue();
                    enemy.IsEnemyAlive = false;
                    GameObject gameObject = Game.getBlankGameObject();
                    this.Controls.Remove(enemy.getBar());
                    enemy.CurrentCell.CurrentGameObject = gameObject;
                }
            }
            removeEnemy();
            openPortalDoor();
        }

        private void removeEnemy()
        {
            for (int x = 0; x < Game.enemies.Count; x++)
            {
                if (Game.enemies[x].IsEnemyAlive == false)
                {
                    Obstacles o = new Obstacles(ELEMENTAL_ARENA.Properties.Resources.Key, Game.enemies[x].CurrentCell, GameObjectType.KEY);
                    Game.enemies.Remove(Game.enemies[x]);
                }
            }
        }


        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            foreach (Bullet b in Game.enemyBullets)
            {
                b.move();
            }
            for (int x = 0; x < Game.enemyBullets.Count; x++)
            {
                if (Game.enemyBullets[x].getIsActive() == false)
                {
                    Game.enemyBullets.RemoveAt(x);
                }
            }

            foreach (Bullet b in Game.bullets)
            {
                b.move();
            }

            for (int x = 0; x < Game.bullets.Count; x++)
            {
                if (Game.bullets[x].getIsActive() == false)
                {
                    Game.bullets.RemoveAt(x);
                }
            }
        }


        private void openPortalDoor()
        {
            if (fury.getKey() == 2)
            {
                foreach (Obstacles o in Game.obstacle)
                {
                    o.remove();
                }
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
