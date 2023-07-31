using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gamePacOop.GameGL
{
    abstract class Ghost : GameObject
    {
        protected GamePacManPlayer pacman;
        public Ghost(GameObjectType gameObjectType, Image image) : base(GameObjectType.ENEMY, image)
        {

        }

        public abstract GameCell move();


    }
}
