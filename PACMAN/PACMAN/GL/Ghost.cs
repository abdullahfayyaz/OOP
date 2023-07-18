using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN.GL
{
    abstract class Ghost : GameObject
    {
        public Ghost(GameObjectType gameObjectType, char displayCharacter) : base(GameObjectType.ENEMY, displayCharacter)
        {
           
        }
        public abstract GameCell move(GameDirection direction);

        public abstract void movement();
        public abstract void moveGhost(Ghost Gh);
      
    }
}
