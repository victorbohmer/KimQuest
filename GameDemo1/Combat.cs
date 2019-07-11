using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    class Combat
    {
        public Monster attackingMonster { get; set; }
        public Combat()
        {
            attackingMonster = GetRandomMonster();
        }

        public CombatOutcome CombatRound()
        {

        }

        private Monster GetRandomMonster()
        {
            //List<Monster> encounterTable = new List<Monster>();

            return new Mygga();


        }
    }
}
