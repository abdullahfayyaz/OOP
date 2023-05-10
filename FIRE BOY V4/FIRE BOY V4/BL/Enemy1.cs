using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRE_BOY_V4.BL
{
    class Enemy1
    {
        public int enemy1X;
        public int enemy1Y;
        public int bulletEnemy1X;
        public int bulletEnemy1Y;

        // Enemy 1 Functionality
        public void printEnemy1(char[,] maze, char[,] enemy1)
        {
            for (int row = 0; row < enemy1.GetLength(0); row++)
            {
                for (int col = 0; col < enemy1.GetLength(1); col++)
                {
                    Console.SetCursorPosition(enemy1Y + col, enemy1X + row);
                    Console.Write(enemy1[row, col]);
                    maze[enemy1X + row, enemy1Y + col] = enemy1[row, col];
                }
            }
        }
        public void eraseEnemy1(char[,] maze, char[,] enemy1)
        {
            for (int row = 0; row < enemy1.GetLength(0); row++)
            {
                for (int col = 0; col < enemy1.GetLength(1); col++)
                {
                    Console.SetCursorPosition(enemy1Y + col, enemy1X + row);
                    Console.Write(" ");
                    maze[enemy1X + row, enemy1Y + col] = ' ';
                }
            }
        }
        public void makeBulletInactiveE1(int index, bool[] isBulletEnemy1Active)
        {

            isBulletEnemy1Active[index] = false;
        }
        public void moveEnemy1(char[,] maze, char[,] enemy1, ref string enemyDirection1)
        {
            if (maze[enemy1X, enemy1Y + 2] == ' ' && maze[enemy1X + 1, enemy1Y - 1] == ' ' && maze[enemy1X + 2, enemy1Y + 2] == ' ')
            {
                if (enemyDirection1 == "left")
                {
                    if (maze[enemy1X + 3, enemy1Y + 3] == '%')
                    {
                        eraseEnemy1(maze, enemy1);
                        enemy1Y = enemy1Y - 1;
                        printEnemy1(maze, enemy1);
                    }
                    if (maze[enemy1X + 3, enemy1Y + 3] == '|')
                    {
                        enemyDirection1 = "right";
                    }
                }
                if (enemyDirection1 == "right")
                {
                    if (maze[enemy1X + 3, enemy1Y + 5] == '%')
                    {
                        eraseEnemy1(maze, enemy1);
                        enemy1Y = enemy1Y + 1;
                        printEnemy1(maze, enemy1);
                    }
                    if (maze[enemy1X + 3, enemy1Y + 5] == '|')
                    {
                        enemyDirection1 = "left";
                    }
                }
            }
        }
        public void enemy1_health(char[,] maze, char[,] enemy1, ref bool enemy1Present, ref int enemy1Health)    // Health
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            char bar1 = (char)124;
            char bar2 = (char)166;
            Console.SetCursorPosition(110, 8);
            Console.Write("ENEMY 1 (ICY) HEALTH: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(135, 8);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(bar1);
            }
            Console.Write("\r");
            Console.ForegroundColor = ConsoleColor.Blue;
            if (enemy1Health == 200)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 190)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 19; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 180)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 18; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 170)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 17; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 160)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 16; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 150)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 15; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 140)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 14; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 130)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 13; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 120)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 12; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 110)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 11; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 100)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 90)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 80)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 70)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 60)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 50)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 40)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 30)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 20)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 10)
            {
                Console.SetCursorPosition(135, 8);
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (enemy1Health == 0)
            {
                removeEnemy1(maze, enemy1, ref enemy1Present, ref enemy1Health);
                // fallKey();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void removeEnemy1(char[,] maze, char[,] enemy1, ref bool enemy1Present, ref int enemy1Health)
        {
            eraseEnemy1(maze, enemy1);
            enemy1Present = false;
            // keyX = enemy1X;
            // keyY = enemy1Y;
            enemy1X = 45;
            enemy1Y = 0;
            // stopEnemy2 = false;
            // isEnemy2Free = true;
        }

        // Enemy 1 Icy Bullet
        public void printEnemy1Bullet(char[,] maze, int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write("*");
            maze[x, y] = '*';
        }
        public void eraseEnemy1Bullet(char[,] maze, int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(" ");
            maze[x, y] = ' ';
        }
        public void generateEnemy1Bullet(char[,] maze, List<Enemy1> bullet, ref int enemy1Shot, ref bool stopEnemy, char rightHand)
        {
            char nextLocation = maze[enemy1X + 1, enemy1Y - 20];
            if (nextLocation == rightHand)
            {
                if (enemy1Shot % 5 == 0)
                {
                    char next = maze[enemy1X + 1, enemy1Y - 1];
                    if (next == ' ')
                    {
                        Enemy1 e = new Enemy1();
                        e.bulletEnemy1X = enemy1X + 1;
                        e.bulletEnemy1Y = enemy1Y - 1;
                        printEnemy1Bullet(maze, enemy1X + 1, enemy1Y - 1);
                        bullet.Add(e);
                    }
                }
                enemy1Shot++;
                stopEnemy = true;
            }
            else
            {
                stopEnemy = false;
            }
        }
        public void moveEnemy1Bullet(char[,] maze, List<Enemy1> e)
        {
            for (int x = 0; x < e.Count(); x++)
            {
                char next1 = maze[e[x].bulletEnemy1X, e[x].bulletEnemy1Y - 1];
                char next2 = maze[e[x].bulletEnemy1X - 1, e[x].bulletEnemy1Y];
                char next3 = maze[e[x].bulletEnemy1X + 1, e[x].bulletEnemy1Y];
                if (next1 != ' ')
                {
                    eraseEnemy1Bullet(maze, e[x].bulletEnemy1X, e[x].bulletEnemy1Y);
                    e.RemoveAt(x);
                }
                else if (next1 == ' ' || next1 == '.')
                {
                    eraseEnemy1Bullet(maze, e[x].bulletEnemy1X, e[x].bulletEnemy1Y);
                    e[x].bulletEnemy1Y = e[x].bulletEnemy1Y - 1;
                    printEnemy1Bullet(maze, e[x].bulletEnemy1X, e[x].bulletEnemy1Y);
                }
                if (next2 != ' ')
                {
                    eraseEnemy1Bullet(maze, e[x].bulletEnemy1X, e[x].bulletEnemy1Y);
                    e.RemoveAt(x);
                }
                if (next3 != ' ')
                {
                    eraseEnemy1Bullet(maze, e[x].bulletEnemy1X, e[x].bulletEnemy1Y);
                    e.RemoveAt(x);
                }
            }
        }
    }
}
