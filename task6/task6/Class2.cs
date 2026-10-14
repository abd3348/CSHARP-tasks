using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Warrior : GameCharacter
    {
        public Warrior(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine(
                "The Warrior attacks with a sword!"
            );
        }

        public override void TakeDamage(int amount)
        {
            int damage = Math.Max(0, amount - 2);

            base.TakeDamage(damage);
        }
    }
}
