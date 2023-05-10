using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRE_BOY_V4.BL
{
    class Fireboy
    {
        public int fireBoyX;
        public int fireBoyY;
        public int bulletX;
        public int bulletY;

        // Player Functionality
        public void printFireboy(char[,] maze, char[,] fireboy)
        {
            for (int row = 0; row < fireboy.GetLength(0); row++)
            {
                for (int col = 0; col < fireboy.GetLength(1); col++)
                {
                    Console.SetCursorPosition(fireBoyY + col, fireBoyX + row);
                    Console.Write(fireboy[row, col]);
                    maze[fireBoyX + row, fireBoyY + col] = fireboy[row, col];
                }
            }
        }
        public void eraseFireboy(char[,] maze, char[,] fireboy)
        {
            for (int row = 0; row < fireboy.GetLength(0); row++)
            {
                for (int col = 0; col < fireboy.GetLength(1); col++)
                {
                    Console.SetCursorPosition(fireBoyY + col, fireBoyX + row);
                    Console.Write(" ");
                    maze[fireBoyX + row, fireBoyY + col] = ' ';
                }
            }
        }
        public void fireBoyRight(char[,] maze, char[,] fireboy)
        {
            if ((maze[fireBoyX, fireBoyY + 3] == ' ' || maze[fireBoyX, fireBoyY + 3] == '@') && (maze[fireBoyX + 1, fireBoyY + 3] == ' ' || maze[fireBoyX + 1, fireBoyY + 3] == '@') && (maze[fireBoyX + 2, fireBoyY + 3] == ' ' || maze[fireBoyX + 2, fireBoyY + 3] == '@'))
            {
                eraseFireboy(maze, fireboy);
                fireBoyY = fireBoyY + 1;
                printFireboy(maze, fireboy);
            }
        }
        public void fireBoyLeft(char[,] maze, char[,] fireboy)
        {
            if ((maze[fireBoyX, fireBoyY - 1] == ' ' || maze[fireBoyX, fireBoyY - 1] == '@') && (maze[fireBoyX + 1, fireBoyY - 1] == ' ' || maze[fireBoyX + 1, fireBoyY - 1] == '@') && (maze[fireBoyX + 2, fireBoyY - 1] == ' ' || maze[fireBoyX + 2, fireBoyY - 1] == '@'))
            {
                eraseFireboy(maze, fireboy);
                fireBoyY = fireBoyY - 1;
                printFireboy(maze, fireboy);
            }
        }
        public void fireBoyJump(char[,] maze, char[,] fireboy)
        {
            if ((maze[fireBoyX - 2, fireBoyY] == ' ' || maze[fireBoyX - 2, fireBoyY] == '@') && (maze[fireBoyX - 2, fireBoyY + 1] == ' ' || maze[fireBoyX - 2, fireBoyY + 1] == '@') && (maze[fireBoyX - 2, fireBoyY + 2] == ' ' || maze[fireBoyX - 2, fireBoyY + 2] == '@'))
            {
                if ((maze[fireBoyX + 3, fireBoyY] == '#' || maze[fireBoyX + 3, fireBoyY] == '%' || maze[fireBoyX + 3, fireBoyY] == '|') && (maze[fireBoyX + 3, fireBoyY + 1] == '#' || maze[fireBoyX + 3, fireBoyY + 1] == '%' || maze[fireBoyX + 3, fireBoyY + 1] == '|') && (maze[fireBoyX + 3, fireBoyY + 2] == '#' || maze[fireBoyX + 3, fireBoyY + 2] == '%' || maze[fireBoyX + 3, fireBoyY + 2] == '|'))
                {
                    eraseFireboy(maze, fireboy);
                    fireBoyX = fireBoyX - 6;
                    printFireboy(maze, fireboy);
                }
            }
        }
        public void fireBoyDown(char[,] maze, char[,] fireboy)
        {
            if ((maze[fireBoyX + 3, fireBoyY] == ' ' || maze[fireBoyX + 3, fireBoyY] == '@') && (maze[fireBoyX + 3, fireBoyY + 1] == ' ' || maze[fireBoyX + 3, fireBoyY + 1] == '@') && (maze[fireBoyX + 3, fireBoyY + 2] == ' ' || maze[fireBoyX + 3, fireBoyY + 2] == '@'))
            {
                eraseFireboy(maze, fireboy);
                fireBoyX = fireBoyX + 1;
                printFireboy(maze, fireboy);
            }
        }
        public void playerHealth(ref int fireBoyHealth, ref int healthCount)        // Player Health
        {
            char bar1 = (char)124;
            char bar2 = (char)166;
            char heart = (char)3;
            Console.SetCursorPosition(110, 6);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("FIRE BOY HEALTH: ");
            if (healthCount == 3)
            {
                Console.SetCursorPosition(128, 6);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(heart + " ");
                }
            }
            else if (healthCount == 2)
            {
                Console.SetCursorPosition(128, 6);
                for (int i = 0; i < 3; i++)
                {
                    if (i < 2)
                    {
                        Console.Write(heart + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            else if (healthCount == 1)
            {
                Console.SetCursorPosition(128, 6);
                for (int i = 0; i < 3; i++)
                {
                    if (i < 1)
                    {
                        Console.Write(heart + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.SetCursorPosition(135, 6);       // Health Bar
            for (int i = 0; i < 20; i++)
            {
                Console.Write(bar1);
            }
            Console.Write("\r");
            if (fireBoyHealth == 200)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 190)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 19; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 180)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 18; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 170)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 17; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 160)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 16; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 150)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 15; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 140)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 14; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 130)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 13; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 120)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 12; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 110)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 11; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 100)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 90)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 80)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 70)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 60)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 50)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 40)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 30)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 20)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(bar2);
                }
            }
            else if (fireBoyHealth == 10)
            {
                Console.SetCursorPosition(135, 6);
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(bar2);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void restartFireBoy(char[,] maze, char[,] fireboy, ref int fireBoyHealth, ref int healthCount)
        {
            if (fireBoyHealth == 0)
            {
                eraseFireboy(maze, fireboy);
                fireBoyX = 40;
                fireBoyY = 3;
                printFireboy(maze, fireboy);
                fireBoyHealth = 200;
                healthCount--;
                playerHealth(ref fireBoyHealth, ref healthCount);
            }
        }
        // Player Bullet
        public void printbullet(char[,] maze, int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(".");
            maze[x, y] = '.';
        }
        public void erasebullet(char[,] maze, int x, int y)
        {
            Console.SetCursorPosition(y, x);
            Console.Write(" ");
            maze[x, y] = ' ';
        }
        public void generatePlayerBullet(char[,] maze, List<Fireboy> fireBoyBullet)
        {
            if (maze[fireBoyX + 1, fireBoyY + 3] == ' ')
            {
                Fireboy b = new Fireboy();
                b.bulletX = fireBoyX + 1;
                b.bulletY = fireBoyY + 3;
                printbullet(maze, bulletX, bulletY);
                fireBoyBullet.Add(b);
            }
        }
        public void makeBulletInactive(int index, bool[] isBulletActive)
        {
            isBulletActive[index] = false;
        }
        public void movePlayerBullet(char[,] maze, List<Fireboy> player)
        {
            for (int i = 0; i < player.Count(); i++)
            {
                char next = maze[player[i].bulletX, player[i].bulletY + 1];
                if (next != ' ')
                {
                    erasebullet(maze, player[i].bulletX, player[i].bulletY);
                    player.RemoveAt(i);
                }
                else if (next == ' ')
                {
                    erasebullet(maze, player[i].bulletX, player[i].bulletY);
                    player[i].bulletY = player[i].bulletY + 1;
                    printbullet(maze, player[i].bulletX, player[i].bulletY);
                }
            }
        }
    }
}
