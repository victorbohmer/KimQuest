using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo1
{
    class Tile
    {
        public string Name { get; private set; }
        public bool Traversable { get; private set; }
        public Tile(string name, bool traversable)
        {
            Name = name;
            Traversable = traversable;
        }

    }
}
