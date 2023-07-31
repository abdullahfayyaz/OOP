using ELEMENTAL_ARENA.GameGL;
using EZInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA
{
    public partial class GameForm2 : Form
    {
        GameGrid grid;
        Fury fury;
        SmartEnemy rage;
        RandomEnemy airy;
        RandomEnemy airy2;

        public GameForm2()
        {
            InitializeComponent();
        }

        private void GameForm2_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze2.txt", 14, 28);

            Image furyImage = GameGL.Game.getGameObjectImage('F');
            GameCell startCell = grid.getCell(12, 3);
            fury = new Fury(this, furyImage, startCell, 0, 100);

            Image rageImage = Game.getGameObjectImage('S');
            GameCell rageStartCell = grid.getCell(6, 10);
            rage = new SmartEnemy(this, 100, fury, GameDirection.Left, rageImage, rageStartCell);

            Image airyImage = Game.getGameObjectImage('R');
            GameCell airyStartCell = grid.getCell(10, 18);
            airy = new RandomEnemy(this, 100, fury, GameDirection.Left, airyImage, airyStartCell);

            Image airy2Image = Game.getGameObjectImage('R');
            GameCell airy2StartCell = grid.getCell(4, 10);
            airy2 = new RandomEnemy(this, 100, fury, GameDirection.Left, airy2Image, airy2StartCell);

            Game.enemies.Add(rage);
            Game.enemies.Add(airy);
            Game.enemies.Add(airy2);

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
        private void openPoralDoor()
        {
            if (fury.MagicLamp == true)
            {
                MagicBallLabel.Text = "1";
                foreach (Obstacles o in Game.obstacle)
                {
                    if (o.GameObjectType == GameObjectType.OBSTACLE)
                    {
                        o.remove();
                    }
                }
            }
        }

        private void openMagicLampDoor()
        {
            if (fury.getKey() == 3)
            {
                foreach (Obstacles o in Game.obstacle)
                {
                    if (o.GameObjectType == GameObjectType.OBSTACLE2)
                    {
                        o.remove();
                    }
                }
            }
        }

        private void Bullet_Tick(object sender, EventArgs e)
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

        private void Gametimer_Tick(object sender, EventArgs e)
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

            if (fury.IsPortalOpen == true)
            {
                Gametimer.Enabled = false;
                MessageBox.Show("GAME COMPLETED", "LEVEL 2 COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LastForm lastForm = new LastForm();
                lastForm.ShowDialog();
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
                    enemy.IsEnemyAlive = false;
                    GameObject gameObject = Game.getBlankGameObject();
                    this.Controls.Remove(enemy.getBar());
                    enemy.CurrentCell.CurrentGameObject = gameObject;
                }
            }
            removeEnemy();
            openPoralDoor();
            openMagicLampDoor();
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

        private void GameForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
