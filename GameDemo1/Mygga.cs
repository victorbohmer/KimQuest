using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo1
{
    class Mygga : Monster
    {
        public Mygga()
        {
            Health = 40;
            Name = "Mygga";
            NameSubject = "Myggan";
            minDamage = 4;
            maxDamage = 8;
            MonsterXp = 30;
        }
    }
}
