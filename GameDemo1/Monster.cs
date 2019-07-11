using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1
{
    abstract class Monster
    {
        public int Health { get; protected set; }
        public string Name { get; protected set; }

        protected int minDamage;
        protected int maxDamage;

        protected int minGold;
        protected int maxGold;

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
        public string TakeDamage(int damageTaken)
        {
            if (damageTaken < Health)
            {
                Health -= damageTaken;
                return $"Du gjorde {damageTaken} i skada på monster {Name} monster har nu {Health} i liv";
            }
            else
            {
                return "BOOM!! Du SMÄÄÄÄCKAAA monster!";
            }

        }
    }
}
