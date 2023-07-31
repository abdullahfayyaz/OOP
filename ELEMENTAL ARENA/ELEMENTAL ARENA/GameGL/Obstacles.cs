using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ELEMENTAL_ARENA.GameGL
{
    class Obstacles : GameObject
    {
        public Obstacles(Image image, GameCell startCell, GameObjectType objType) : base(objType, image)
        {
            this.CurrentCell = startCell;
        }

        public void remove()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, null);
            this.CurrentCell.setGameObject(blankGameObject);
        }

    }
}
