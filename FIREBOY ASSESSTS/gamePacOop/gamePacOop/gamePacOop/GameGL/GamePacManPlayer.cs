using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gamePacOop.GameGL
{
    class GamePacManPlayer : GameObject
    {
        private int lives;
        private int scores;
        public GamePacManPlayer(int scores, int lives, Image image, GameCell startCell) : base(GameObjectType.PLAYER, image)
        {
            this.lives = lives;
            this.scores = scores;
            this.CurrentCell = startCell;
        }

        public int Lives { get => lives; set => lives = value; }

        public int getLives()
        {
            return lives;
        }

        public void increasLive()
        {
            lives++;
        }

        public void decreasLive()
        {
            lives--;
        }

        public GameCell move(GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            addScores(nextCell);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

        private void addScores(GameCell nextCell)
        {
            if(nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                scores++;
            }
    
        }

        public int getScores()
        {
            return scores;
        }
    }
}