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
        TextBox textBox;
        public Combat(TextBox textBox)
        {
            this.textBox = textBox;
            attackingMonster = GetRandomMonster();
        }

        public void NewMonster()
        {
            attackingMonster = GetRandomMonster();
        }

        public CombatOutcome CombatRound()
        {
            CombatOutcome combatOutcome;

            int playerDamage = Player.DoDamage();
            combatOutcome = attackingMonster.TakeDamage(playerDamage);

            LogPlayerDamage(playerDamage);

            if (combatOutcome == CombatOutcome.PlayerWon)
            {
                LogPlayerWon();
                return combatOutcome;
            }

            int monsterDamage = attackingMonster.DoDamage();
            combatOutcome = Player.TakeDamage(monsterDamage, attackingMonster.NameSubject);

            LogMonsterDamage(monsterDamage);

            if (combatOutcome == CombatOutcome.PlayerLost)
            {
                LogPlayerLost();
                return combatOutcome;
            }

            return CombatOutcome.NewRound;

        }

        private void LogPlayerLost()
        {
            textBox.Text += "\nDu är FAN SMÄÄÄÄCKAAAD!";
        }

        private void LogPlayerWon()
        {
            textBox.Text += $"\nBOOM!! Du SMÄÄÄÄCKAAA {attackingMonster.NameSubject.ToLower()}!";
        }

        private void LogPlayerDamage(int playerDamage)
        {
            textBox.Text += $"\nDu smäll till {attackingMonster.NameSubject.ToLower()} för {playerDamage} skada.";
        }

        private void LogMonsterDamage(int monsterDamage)
        {
            textBox.Text += $"\n{attackingMonster.Name} smäll tillbax för {monsterDamage} skada!";

        }

        private Monster GetRandomMonster()
        {

            int monsterType = random.Next(4);

            switch (monsterType)
            {
                case 1:
                    return new Björn();
                case 2:
                    return new NollÅtta();
                case 3:
                    return new Pikachu();
                default:
                    return new Mygga();
            }

        }
    }
}
