using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Game
{
    internal class Sword : Weapon
    {
        public Sword(string name, int damage) : base(name, damage)
        {
        }

        public override int GiveDamage()
        {
            return Damage;
        }
    }
}
