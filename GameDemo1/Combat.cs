using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace GameDemo1
{
    class Combat
    {
        public Monster attackingMonster { get; set; }
        Random random = new Random();
        public Combat()
        {
            attackingMonster = GetRandomMonster();
        }

        public void NewMonster()
        {
            attackingMonster = GetRandomMonster();
        }

        public CombatOutcome CombatRound(TextBox textBox)
        {

            int playerDamage = Player.DoDamage();
            string attackResponse = attackingMonster.TakeDamage(playerDamage);

            textBox.Text += "\n" + attackResponse;

            if (attackResponse.Contains($"BOOM!! Du SMÄÄÄÄCKAAA"))
                return CombatOutcome.PlayerWon;

            int monsterDamage = attackingMonster.DoDamage();
            string defenceResponse = Player.TakeDamage(monsterDamage, attackingMonster.NameSubject);

            textBox.Text += "\n" + defenceResponse;

            if (defenceResponse.Contains("Du är FAN SMÄÄÄÄCKAAAD!"))
                return CombatOutcome.PlayerLost;

            //Implicit else
            return CombatOutcome.NewRound;


        }

        private Monster GetRandomMonster()
        {
            //List<Monster> encounterTable = new List<Monster>();

            int monsterType = random.Next(3);

            switch (monsterType)
            {
                case 1:
                    return new Björn();
                case 2:
                    return new NollÅtta();
                default:
                    return new Mygga();
            }

            


        }
    }
}
