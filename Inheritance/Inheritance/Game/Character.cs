using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Game
{
    internal class Character
    {
        public string Name { get; set; }
        
        private int _health = 100;
        public  List<Weapon> Weapons { get; private set; }

        public Character(string name,List<Weapon> weapons)
        {
            Name = name;
            Weapons = (List<Weapon>?)weapons;
        }

        public void Hit(Weapon weapon, Character target)
        {if (_health > 0 && target._health > 0 && Weapons.Contains(weapon) && Name != target.Name)
            {  

                target._health -= weapon.GiveDamage();
                Console.WriteLine($"{Name} used {weapon.Name} against {target.Name}, {target.Name}'s Damage = {weapon.Damage}, Health = {target._health}");
                if (target._health <= 0)
                {
                    Console.WriteLine($" character : {target.Name} is dead ");
                    Console.WriteLine(" GAME OVER ");
                }

            }
            else if (target._health <= 0 || _health <= 0 )
            {
                
                Console.WriteLine(" GAME OVER ");
            }
        else if (Name == target.Name)
            {

                target.TakeDamage(weapon.Damage);

            }
            else
            {
                Console.WriteLine($" character {Name} doesn't have {weapon.Name} weapon ");
            }
           
        }
        public void TakeDamage(int damage)
        {
            if (_health > damage)
            {
                _health -= damage;
                Console.WriteLine($" character {Name} took self damage = {damage}, remaining health = {_health} ");
            }
            else
            {
                Console.WriteLine(" character killed himself ");
                Console.WriteLine(" GAME OVER ");
            }
        }
    }
}
