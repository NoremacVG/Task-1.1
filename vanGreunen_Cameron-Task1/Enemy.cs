using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanGreunen_Cameron_Task1
{
    abstract class Enemy : Character
    {
        protected Random random;

        public Enemy(int x, int y, int damage, int hp) : base (x, y, TileType.ENEMY)
        {
            this.damage = damage;
            this.hp = hp;
            this.maxHP = hp; //max hp will be equal to initial max HP
        }

        public override string ToString()
        {
            return GetType() + "at [" + x + "," + y + "] (" + damage + ")";
        }
    }
}
