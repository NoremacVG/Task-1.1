using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanGreunen_Cameron_Task1
{
     abstract class Character : Tile
    {
        class Character : Tile
        {
            protected int hp;
            protected int maxHP;
            protected int damage;
            protected Tile[] vision;
            protected Movement movement;

            public int HP
            {
                get { return hp; }
                set { hp = value; }
            }

            public Tile[] Vision
            {
                get { return vision; }
                set { vision = value; }
            }

            public Character(int x, int y, TileType type) : base(x, y, type)
            {
                vision = new Tile[4]; //0 = UP, 1 = down, 2 = left, 3 = right
            }

            public virtual void attack(Character target)
            {
                target.hp -= this.damage;
            }

            public bool IsDead()
            {
                return hp <= 0;
            }
            public virtual bool CheckRange(Character target)
            {
                return DistanceTo(target) <= 1;
            }

            private int DistanceTo(Character target)
            {
                return Math.Abs(x - target.X) + Math.Abs(y - target.Y);
            }

            public void Move(Movement movement)
            {
                switch (movement)
                {
                    case Movement.UP: y -= 1; break;
                    case Movement.DOWN: y += 1; break;
                    case Movement.LEFT: x -= 1; break;
                    case Movement.RIGHT: x += 1; break;
                }
            }
            public void SetVision(Tile up, Tile down, Tile left, Tile right)
            {
                vision[0] = up;
                vision[1] = down;
                vision[2] = left;
                vision[3] = right;
            }
        }

            public abstract Movement ReturnMove(Movement move = 0);

            public abstract override string ToString();
        }


        public enum Movement
        {
            NO_MOVEMENT, //0
            UP,          //1
            DOWN,       //2
            LEFT,       //3
            RIGHT       //4
        }
    }

