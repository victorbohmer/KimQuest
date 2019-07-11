using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    class Monster
    {
        public int Health { get; private set; }
        private int minDamage;
        private int maxDamage;

        private int minGold;
        private int maxGold;
        public Monster()
        {
            minDamage = 10;
            maxDamage = 20;
            Health = 100;
        }
        public int DropGold()
        {
            Random random = new Random();
            return random.Next(minGold, maxGold);
        }
        public int DoDamage()
        {
            Random random = new Random();
            return random.Next(minDamage, maxDamage);
        }
    }
}
