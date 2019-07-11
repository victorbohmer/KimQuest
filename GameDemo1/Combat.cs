using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    class Combat
    {
        Monster attackingMonster;
        public Combat()
        {

            attackingMonster = GetRandomMonster();

        }

        private Monster GetRandomMonster()
        {
            throw new NotImplementedException();
        }
    }
}
