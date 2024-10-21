using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name,age) 
        {
            Subject = subject;

        }

       public override void DisplayInfo()
        {
            if (Subject != null && Name != null && Age != 0)
            {
                Console.WriteLine($" The Teacher's Name is : {Name}, Age : {Age}, Subject : {Subject} ");
            }
            else
            {
                Console.WriteLine(" enter all three : Name, Age and Subject ");
            }

        }
        public override void Describe()
        {
            Console.WriteLine(" i am a Teacher ");
        }

        public override string GetOccupation()
        {
            return $" {Name} is Teacher ";
        }
    }
}
