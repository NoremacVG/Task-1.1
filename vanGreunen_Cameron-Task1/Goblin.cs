using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanGreunen_Cameron_Task1
{
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y, 1, 10)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NO_MOVEMENT)
        {
            int dir = random.Next(1, 5);

            int maxTries = 10;
            int tries = 0;
            while (vision[dir - 1].Type == TileType.EMPTY && tries < maxTries)
            {
                dir = random.Next(1, 5);
                tries++;

                if (tries == maxTreis)
                {
                    return Movement.NO_MOVEMENT;
                }
            }
            return (Movement.dir);
        }
    }
}
