using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELEMENTAL_ARENA.GameGL
{
    class Game
    {
        public static List<Bullet> bullets = new List<Bullet>();
        public static List<Enemy> enemies = new List<Enemy>();
        public static List<EnemyBullet> enemyBullets = new List<EnemyBullet>();
        public static List<Obstacles> obstacle = new List<Obstacles>();

        internal GameObject GameObject
        {
            get => default;
            set
            {
            }
        }

        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, null);
            return blankGameObject;
        }

        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = null;

            if (displayCharacter == '#' || displayCharacter == '%' || displayCharacter == '!')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Black_Wall;
            }

            if ( displayCharacter == '|' || displayCharacter == '-' || displayCharacter == '{' || displayCharacter == '}')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Vertical_Black_Wall;
            }

            if(displayCharacter == '&' || displayCharacter == '[')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.bars;
            }

            if (displayCharacter == '_' || displayCharacter == '\\')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Horizontalbars;
            }

            if (displayCharacter == 'F')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.FuryRight;
            }

            if (displayCharacter == 'Z')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.FuryFire;
            }

            if (displayCharacter == '@')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Pallet;
            }

            if (displayCharacter == 'H')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.PoisonLeft;
            }

            if (displayCharacter == 'P')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.PoisonFire;
            }

            if (displayCharacter == 'V')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.WateryLeft;
            }

            if (displayCharacter == 'W')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.WateryFire;
            }

            if (displayCharacter == 'S')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.RageLeft;
            }

            if (displayCharacter == 'r')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.RageFire;
            }

            if (displayCharacter == 'R')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.AiryLeft;
            }

            if (displayCharacter == 'A')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.AiryFire;
            }

            if (displayCharacter == 'K')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Key;
            }

            if (displayCharacter == 'O')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Portal;
            }

            if (displayCharacter == '0')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Portal2;
            }

            if (displayCharacter == 'M')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.MagicLamp;
            }

            if (displayCharacter == '+')
            {
                img = ELEMENTAL_ARENA.Properties.Resources.Health;
            }

            return img;
        }
    }
}
