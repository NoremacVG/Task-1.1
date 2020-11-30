using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanGreunen_Cameron_Task1
{
    class Map
    {
        Tile[,] map;
        Hero hero;
        Enemy[] enimies;

        int width;
        int height;

        Random random = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
        {
            width = random.Next(minWidth, maxWidth + 1);
            height = random.Next(minHeight, maxHeight + 1);

            map = new Tile[width, height];
            enimies = new Enemy[numEnemies];

            InitializeMap();

            hero = (Hero)Create(TileType.HERO);
            for (int i = 0; i < enimies.Length, i++)
            {
                enimies[i] = (Enemy)Create(TileType.ENEMY);
            }
        }

        private void InitializeMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width, x++)
                {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }

                }
            }
        }

        public void Create(TileType type)
        {
            int x = random.Next(0, width);
            int y = random.Next(0, height);

            while (map[x, y].Type != TileType.EMPTY)
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            }

            if (type == TileType.HERO)
            {
                map[x, y] = new Hero(x, y, 10);

            }
            else if (type == TileType.ENEMY)
            {
                map[x, y] = new Goblin(x, y);

            }

            return map[x, y];
        }

        public void UpdateCharacterVision(haracter character)
        {        
            Tile heroUP = null;
            Tile heroDown = null;
            Tile heroLeft = null;
            Tile heroRight = null;

            if (hero.y - 1 < height)
            {
                heroUP = map[hero.x, hero.y + 1];
            }
            if (hero.y + 1 >= 0)
            {
                heroDown = map[hero.x, hero.y - 1];
            }
            if (hero.x - 1 < width)
            {
                heroLeft = map[hero.x - 1, hero.y];
            }
            if (hero.y + 1 >= 0)
            {
                heroRight = map[hero.x + 1, hero.y];
            }

            character.SetVision(heroUP, heroDown, heroLeft, heroRight);              
        }
         public void Update()
        {
            InitializeMap();

            map[hero.X, hero.Y] = hero;

            for int i = 0; i < enemies.Length; i++)
            {
                Enemy currentEnemy = enemies[i];
                map[currentEnemy.X, currentEnemy.Y] = enemies[i];
            }
            UpdateVision();
        }
        public override string ToString()
        {
            string mapString = "";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    TileType currentType = map[x,y].Type
                    if (map[x, y].Type == TileType.HERO)
                    {
                        mapString += 'H';
                    }
                    else if (currentType == TileType.ENEMY)
                    {
                        mapString += 'G';
                    }
                    else if (currentType == TileType.EMPTY)
                    {
                        mapString += '.';
                    }
                    else if (currentType == TileType.OBSTACLE)
                    {
                        mapString += 'X';
                    }
                    
                }
                mapString += "/n";
            }

            return mapString;
        }
    }
}
