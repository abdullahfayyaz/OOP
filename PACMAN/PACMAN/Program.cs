using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using PACMAN.GL;

namespace PACMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(12, 22, grid);
            GamePacManPlayer pacman = new GamePacManPlayer('p', start);

            GameCell H1Start = new GameCell(15, 15, grid);
            Horizontal_Ghost H1Ghost = new Horizontal_Ghost(GameDirection.Left, 'H', H1Start);

            GameCell H2Start = new GameCell(16, 18, grid);
            Horizontal_Ghost H2Ghost = new Horizontal_Ghost(GameDirection.Right, 'G', H1Start);

            GameCell V1Start = new GameCell(15, 50, grid);
            Vertical_Ghost V1Ghost = new Vertical_Ghost(GameDirection.Up, 'V', V1Start);

            GameCell R1Start = new GameCell(19, 50, grid);
            RandomGhost R1Ghost = new RandomGhost( 'R', V1Start);

            GameCell S1Start = new GameCell(16, 50, grid);
            Smart_Ghost S1Ghost = new Smart_Ghost(0,'S', S1Start);


            List<Ghost> listGhost = new List<Ghost>();

            listGhost.Add(H1Ghost);
            listGhost.Add(H2Ghost);
            listGhost.Add(V1Ghost);
            listGhost.Add(R1Ghost);
           
            printMaze(grid);
            MovementClass.printGameObject(pacman);

            

            bool gameRunning = true;
            while(gameRunning)
            {
                Thread.Sleep(90);
                if(Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    MovementClass.moveGameObject(pacman, GameDirection.Up);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    MovementClass.moveGameObject(pacman, GameDirection.Down);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    MovementClass.moveGameObject(pacman, GameDirection.Right);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    MovementClass.moveGameObject(pacman, GameDirection.Left);
                }

                foreach(Ghost g in listGhost)
                {
                    g.moveGhost(g);
                }

                S1Ghost.moveGhost(S1Ghost, pacman);



                
               


            }
        }
       

        

        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    printCell(cell);
                }
            }
        }
        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
    }
}
