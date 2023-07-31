using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class GameCell
    {
        int row;
        int col;
        GameObject currentGameObject;
        GameGrid grid;
        PictureBox pictureBox;
        const int width = 55;
        const int height = 55;
        public GameCell(int row, int col, GameGrid grid)
        {
            this.row = row;
            this.col = col;
            pictureBox = new PictureBox();
            pictureBox.Left = col * width;
            pictureBox.Top = row * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.grid = grid;
        }
        public GameCell()
        {

        }

        public GameGrid getGrid()
        {
            return grid;
        }
        public void setGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;
        }
        public GameCell nextCell(GameDirection direction)
        {

            if (direction == GameDirection.Left)
            {
                if (this.col > 0)
                {
                    GameCell ncell = grid.getCell(row, col - 1);
                    if (ncell.CurrentGameObject.GameObjectType == GameObjectType.NONE || ncell.CurrentGameObject.GameObjectType == GameObjectType.REWARD || ncell.CurrentGameObject.GameObjectType == GameObjectType.KEY || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL2 || ncell.CurrentGameObject.GameObjectType == GameObjectType.MAGIC_LAMP || ncell.CurrentGameObject.GameObjectType == GameObjectType.HEALTH)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Right)
            {
                if (this.col < grid.Cols - 1)
                {
                    GameCell ncell = grid.getCell(this.row, this.col + 1);
                    if (ncell.CurrentGameObject.GameObjectType == GameObjectType.NONE || ncell.CurrentGameObject.GameObjectType == GameObjectType.REWARD || ncell.CurrentGameObject.GameObjectType == GameObjectType.KEY || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL2 || ncell.CurrentGameObject.GameObjectType == GameObjectType.MAGIC_LAMP || ncell.CurrentGameObject.GameObjectType == GameObjectType.HEALTH)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.row > 0)
                {
                    GameCell ncell = grid.getCell(this.row - 1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType == GameObjectType.NONE || ncell.CurrentGameObject.GameObjectType == GameObjectType.REWARD || ncell.CurrentGameObject.GameObjectType == GameObjectType.KEY || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL2 || ncell.CurrentGameObject.GameObjectType == GameObjectType.MAGIC_LAMP || ncell.CurrentGameObject.GameObjectType == GameObjectType.HEALTH)
                    {
                        return ncell;
                    }
                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.row < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.row + 1, this.col);
                    if (ncell.CurrentGameObject.GameObjectType == GameObjectType.NONE || ncell.CurrentGameObject.GameObjectType == GameObjectType.REWARD || ncell.CurrentGameObject.GameObjectType == GameObjectType.KEY || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL || ncell.CurrentGameObject.GameObjectType == GameObjectType.PORTAL2 || ncell.CurrentGameObject.GameObjectType == GameObjectType.MAGIC_LAMP || ncell.CurrentGameObject.GameObjectType == GameObjectType.HEALTH)
                    {
                        return ncell;
                    }
                }
            }
            return this; // if can not return next cell return its own reference
        }

        public GameCell nextWallCell(GameDirection direction)
        {

            if (direction == GameDirection.Left)
            {
                if (this.col > 0)
                {
                    GameCell ncell = grid.getCell(row, col - 1);
                    return ncell;
                }
            }

            if (direction == GameDirection.Right)
            {
                if (this.col < grid.Cols - 1)
                {
                    GameCell ncell = grid.getCell(this.row, this.col + 1);

                    return ncell;

                }
            }

            if (direction == GameDirection.Up)
            {
                if (this.row > 0)
                {
                    GameCell ncell = grid.getCell(this.row - 1, this.col);

                    return ncell;

                }
            }

            if (direction == GameDirection.Down)
            {
                if (this.row < grid.Rows - 1)
                {
                    GameCell ncell = grid.getCell(this.row + 1, this.col);

                    return ncell;

                }
            }
            return this; // if can not return next cell return its own reference
        }

        public int X { get => row; set => row = value; }
        public int Y { get => col; set => col = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
        public PictureBox PictureBox { get => pictureBox; set => pictureBox = value; }

        internal GameGrid GameGrid
        {
            get => default;
            set
            {
            }
        }

        public GameDirection GameDirection
        {
            get => default;
            set
            {
            }
        }
    }
}
