using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo1
{
    class NollÅtta : Monster
    {
        public NollÅtta()
        {
            Health = 50;
            Name = "NollÅtta";
            NameSubject = "Nollåttan";
            minDamage = 4;
            maxDamage = 10;
            MonsterXp = 20;
        }
    }
}
