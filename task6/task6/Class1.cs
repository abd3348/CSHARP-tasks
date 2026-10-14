using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    abstract class GameCharacter
    {
        private string _name;
        private int health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > 100)
                {
                    health = 100;
                }
                else
                {
                    health = value;
                }
            }
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            if (amount < 0)
                return;

            Health -= amount;

            Console.WriteLine(
                Name + " takes " + amount + " damage."
            );
        }

        public void DisplayHealth()
        {
            Console.WriteLine(
                Name + "'s health: " + Health
            );
        }

        
        public void Heal()
        {
            Heal(10);
        }

        public void Heal(int amount)
        {
            if (amount < 0)
                return;

            int oldHealth = Health;

            Health += amount;

            Console.WriteLine(
                Name + " heals " +
                (Health - oldHealth) + " points."
            );

            DisplayHealth();
        }
    }
}
