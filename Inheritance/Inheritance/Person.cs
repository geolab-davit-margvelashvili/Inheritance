using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($" The Name is : {Name}, Age : {Age} ");

        }

        public virtual void Describe()
        {
            Console.WriteLine(" I am a person ");
        }

        public abstract string GetOccupation();
    }
}
