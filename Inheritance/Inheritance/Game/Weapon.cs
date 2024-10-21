using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Game
{
    internal abstract class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int damage)
        {
            if (damage < 100)
            {
                Name = name;
                Damage = damage;
            }
            else
            {
                Name = name;
                Damage = 100;
            }
        }

        public abstract int GiveDamage();
        
    }
}
