using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(
                "===== ADVENTURE GAME ====="
            );

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters =
                new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine(
                    "\n" + character.GetType().Name +
                    " " + character.Name +
                    " enters the game!"
                );

                character.UseSpecialAbility();
                character.TakeDamage(10);
                character.DisplayHealth();

                if (character is Warrior)
                {
                    Console.WriteLine();

                    character.Heal();
                    Console.WriteLine();

                    character.Heal(15);
                }
            }

            Console.WriteLine();

            HealthPotion potion =
                new HealthPotion("Health Potion");

            potion.Collect();

            Console.WriteLine();

            potion.Use(wizard, "15");
            potion.Use(wizard, "abc");

        }
    }
}
