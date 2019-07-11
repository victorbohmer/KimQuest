using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo1
{
    class Map
    {
        List<Tile> map = new List<Tile>();
        public int Width { get; set; }
        public int Height { get; set; }

        int playerVertical = 4;
        int playerHorizontal = 4;

        public string TryToMove(Direction direction)
        {
            if (TileTraversable(direction))
            {
                MovePlayer(direction);
                return $"Moved {direction}";
            }
            else
                return $"Can't go there";
        }

        private bool TileTraversable(Direction direction)
        {
            int[] tileVertHor = DestinationTile(direction);
            int flatIndex = tileVertHor[0] * Width + tileVertHor[1];

            return map[flatIndex].Traversable;

        }
        private void MovePlayer(Direction direction)
        {
            int[] tileVertHor = DestinationTile(direction);
            playerVertical = tileVertHor[0];
            playerHorizontal = tileVertHor[1];
        }

        private int[] DestinationTile(Direction direction)
        {
            int tileVertical = playerVertical;
            int tileHorizontal = playerHorizontal;
            switch (direction)
            {
                case Direction.UP:
                    break;
                case Direction.SOUTHWEST:
                    tileVertical++;
                    tileHorizontal--;
                    break;
                case Direction.SOUTH:
                    tileVertical++;
                    break;
                case Direction.SOUTHEAST:
                    tileVertical++;
                    tileHorizontal++;
                    break;
                case Direction.WEST:
                    tileHorizontal--;
                    break;
                case Direction.DOWN:
                    break;
                case Direction.EAST:
                    tileHorizontal++;
                    break;
                case Direction.NORTHWEST:
                    tileVertical--;
                    tileHorizontal--;
                    break;
                case Direction.NORTH:
                    tileVertical--;
                    break;
                case Direction.NORTHEAST:
                    tileVertical--;
                    tileHorizontal++;
                    break;
                default:
                    break;
            }
            return new int [] { tileVertical, tileHorizontal };

        }

        public void ReadMapFromFile()
        {

            string mapString = File.ReadAllText("map.txt");

            GetMapWidth(mapString);
            GetMapHeight(mapString);

            string trimmedMapString = mapString.Replace("\r\n", ",");

            string[] mapArray = trimmedMapString.Split(',');

            ParseArrayToTiles(mapArray);

        }

        private void ParseArrayToTiles(string[] mapArray)
        {
            foreach (string tileCode in mapArray)
            {

                map.Add(TileFromCode(tileCode));

            }
        }

        private Tile TileFromCode(string tileCode)
        {
            switch (tileCode)
            {
                case "o":
                    return new Tile("Ocean", false);
                case "p":
                    return new Tile("Plains", true);
                case "f":
                    return new Tile("Forest", true);
                default:
                    throw new ArgumentException($"Does not recognize tile code {tileCode}");

            }
        }

        internal string GetUITileName(int uiVertical, int uiHorizontal)
        {

            int mapHorizontal = playerHorizontal + uiHorizontal - 3;
            int mapVertical = playerVertical + uiVertical - 3;
            int flatIndex = mapVertical * Width + mapHorizontal;

            return map[flatIndex].Name;

        }



        private void GetMapHeight(string mapString)
        {
            Height = mapString.Split('\n').Length;
        }

        private void GetMapWidth(string mapString)
        {
            Width = mapString.Split('\n')[0].Split(',').Length;
        }
    }
}
