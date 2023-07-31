using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELEMENTAL_ARENA.GameGL
{
    class GameObject
    {
        char displayCharacter;
        GameObjectType gameObjectType;
        GameCell currentCell;
        Image image;

        public GameObject()
        {

        }
        public GameObject(GameObjectType type, Image image)
        {
            this.gameObjectType = type;
            this.Image = image;
        }
        public GameObject(GameObjectType type, char displayCharacter)
        {
            this.gameObjectType = type;
            this.displayCharacter = displayCharacter;
        }

        public static GameObjectType getGameObjectType(char displayCharacter)
        {

            if (displayCharacter == '%' || displayCharacter == '#')
            {
                return GameObjectType.WALL;
            }

            if (displayCharacter == '|' || displayCharacter == '!' || displayCharacter == '{')
            {
                return GameObjectType.VERTICAL_WALL;
            }

            if (displayCharacter == '-' || displayCharacter == '}')
            {
                return GameObjectType.OBSTACLE2;
            }

            if (displayCharacter == '&' || displayCharacter == '_' || displayCharacter == '\\' || displayCharacter == '[')
            {
                return GameObjectType.OBSTACLE;
            }

            if (displayCharacter == '@')
            {
                return GameObjectType.REWARD;
            }

            if (displayCharacter == 'O')
            {
                return GameObjectType.PORTAL;
            }

            if (displayCharacter == '0')
            {
                return GameObjectType.PORTAL2;
            }

            if (displayCharacter == 'M')
            {
                return GameObjectType.MAGIC_LAMP;
            }

            if (displayCharacter == '+')
            {
                return GameObjectType.HEALTH;
            }

            if (displayCharacter == 'F')
            {
                return GameObjectType.PLAYER;
            }

            if (displayCharacter == 'H' || displayCharacter == 'V' || displayCharacter == 'S' || displayCharacter == 'R')
            {
                return GameObjectType.ENEMY;
            }

            return GameObjectType.NONE;
        }

        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }

        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }

        public GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }
        public Image Image { get => image; set => image = value; }

        internal GameCell GameCell
        {
            get => default;
            set
            {
            }
        }

        public GameObjectType GameObjectType1
        {
            get => default;
            set
            {
            }
        }
    }
}
