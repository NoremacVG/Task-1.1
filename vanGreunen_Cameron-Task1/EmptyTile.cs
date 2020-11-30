using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanGreunen_Cameron_Task1
{
    class EmptyTile : Tile
    {        
            public EmptyTile(int x, int y) : base(x, y, TileType.OBSTACLE)
        {
        }
    }
}
