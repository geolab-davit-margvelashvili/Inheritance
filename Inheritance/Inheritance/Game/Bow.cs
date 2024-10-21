using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Game
{
    internal class Bow : Weapon
    {
        public Bow(string name, int damage) : base(name, damage)
        {
        }

        public override int GiveDamage()
        {
            return Damage;
        }
    }
}
