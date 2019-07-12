using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo1
{
    class Pikachu : Monster
    {
        public Pikachu()
        {
            Health = 30;
            Name = "Pikachu";
            NameSubject = "Pikachun";
            minDamage = 4;
            maxDamage = 6;
            MonsterXp = 25;
        }
    }
}
