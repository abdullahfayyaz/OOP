using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pacman_Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "savemaze.txt";

            Grid mazeGrid = new Grid(24, 71, path);
            Pacman player = new Pacman(9, 20, mazeGrid);
            Ghost ghost1 = new Ghost(15, 39, "left", 'H', 0.1F, ' ', mazeGrid);
            Ghost ghost2 = new Ghost(20, 57, "up", 'V', 0.2F, ' ', mazeGrid);
            Ghost ghost3 = new Ghost(19, 26, "up", 'R', 1F, ' ', mazeGrid);
            Ghost ghost4 = new Ghost(18, 21, "up", 'C', 0.5F, ' ', mazeGrid);

            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(ghost1);
            enemies.Add(ghost2);
            enemies.Add(ghost3);
            enemies.Add(ghost4);
            mazeGrid.Draw();

            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                player.Print(111, 112);
                player.Remove(9, 20);
                player.Move();

                foreach (Ghost g in enemies)
                {
                    g.Remove(9, 20);
                    g.move();

                }

                gameRunning = false;

            }
            Console.ReadKey();
        }
    }
}
