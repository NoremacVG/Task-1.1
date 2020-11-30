using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanGreunen_Cameron_Task1
{
    class Hero : Character
    {
        public Hero(int x, int y, int hp) : base(x, y, TileType.HERO)
        {
            this.damage = 2;
        }

        public override Movement ReturnMove(Movement move = 0)
        {
            int dir = (int)move - 1;
            if (vision[dir] != null && vision[dir].Type == TileType.EMPTY)
            {
                return move;
            }


            return Movement.NO_MOVEMENT;


        }

        public override string ToString()
        {
            return "Player Stats: \n" +
                "HP: " + hp + "/" + maxHP + "\n" +
                "Damage: " + damage + "\n" +
                "[ " + x + ", " + y + " ]";
        }
    }
}
