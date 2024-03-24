using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Player
    {
        // Здоровье игрока
        public int Health { get; private set; }

        
        public void IniChar(int initialHealth)
        {
            Health = initialHealth;
        }

        // Уменьшение здоровья игрока
        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;

            if (Health <= 0)
            {
                Die();
            }
        }

        // Смерть игрока
        public void Die()
        {
            Console.WriteLine("Вы умерли!");
        }
    }
}
