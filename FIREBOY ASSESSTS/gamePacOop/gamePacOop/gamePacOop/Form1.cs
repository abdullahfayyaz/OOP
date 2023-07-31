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
using gamePacOop.GameGL;

namespace gamePacOop
{
    public partial class Form1 : Form
    {
        GameGrid grid;
        GamePacManPlayer pacman;
       

        List<Bullet> bullets = new List<Bullet>();
        List<Ghost> ghosts = new List<Ghost>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 24, 70);
            Image pacManImage = GameGL.Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer( 0,5,pacManImage, startCell);


            HorizontalGhost ghostH1;
            VerticalGhost ghostV1;
            RandomGhost ghostR1;
            SmartGhost ghostS1;

            Image ghostH1Img = GameGL.Game.getGameObjectImage('H');
            GameCell startH1 = grid.getCell(16, 45);
            ghostH1 = new HorizontalGhost(pacman, GameDirection.Left, ghostH1Img, startH1);

            Image ghostV1Img = GameGL.Game.getGameObjectImage('V');
            GameCell startV1 = grid.getCell(6, 23);
            ghostV1 = new VerticalGhost(pacman, GameDirection.Up, ghostV1Img, startV1);

            Image ghostR1Img = GameGL.Game.getGameObjectImage('R');
            GameCell startR1 = grid.getCell(10, 23);
            ghostR1 = new RandomGhost(pacman, ghostR1Img, startR1);

            Image ghostS1Img = GameGL.Game.getGameObjectImage('S');
            GameCell startS1 = grid.getCell(10, 23);
            ghostS1 = new SmartGhost(pacman,2,ghostS1Img, startS1);

            Game.ghosts.Add(ghostH1);
            Game.ghosts.Add(ghostV1);
            Game.ghosts.Add(ghostR1);
            Game.ghosts.Add(ghostS1);

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
                    //        printCell(cell);
                }

            }
        }

        static void printLives()
        {
        

        }
        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pacman.move(GameDirection.Left);
            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.move(GameDirection.Right);
            }
            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.move(GameDirection.Up);
            }
            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.move(GameDirection.Down);
            }
            else if (Keyboard.IsKeyPressed(Key.Space))
            {
                generateBullet();
            }

            //ghost movement
            foreach (Ghost g in Game.ghosts)
            {

                g.move();
            }

            foreach(Bullet b in Game.bullets)
            {
                b.move();
            }
            //live , scores view
            liveLbl.Text = "Lives: " + pacman.getLives();
            scoreLbl.Text = "Scores: " + pacman.getScores();


        }


        void generateBullet()
        {
            Bullet b;
            Image bullet = GameGL.Game.getGameObjectImage('F');
            GameCell startBullet = pacman.CurrentCell.nextCell(GameDirection.Right);
            b = new HorizontalBullet( GameDirection.Right,bullet ,startBullet);

            Game.bullets.Add(b);
        }

        void generateEnemy()
        {
            RandomGhost ghostR1;
            Image ghostR1Img = GameGL.Game.getGameObjectImage('R');
            GameCell startR1 = grid.getCell(10, 23);
            ghostR1 = new RandomGhost(pacman, ghostR1Img, startR1);
        }
    }
}
