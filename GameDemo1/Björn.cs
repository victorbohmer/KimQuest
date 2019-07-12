using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo1
{
    class Björn : Monster
    {
        public Björn()
        {
            Health = 80;
            Name = "Björn";
            NameSubject = "Björnen";
            minDamage = 8;
            maxDamage = 12;
        }
    }
}
