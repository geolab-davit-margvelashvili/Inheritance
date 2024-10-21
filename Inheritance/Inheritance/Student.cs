using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string name,int age,int studentId) : base(name, age)
        {
            StudentId = studentId;

        }
            

        public override void DisplayInfo()
        {
            if (StudentId != 0 && Name != null && Age != 0)
            {
                Console.WriteLine($" The Student's Name is : {Name}, Age : {Age}, Student Id : {StudentId} ");
            }

            else
            {
                Console.WriteLine(" enter all three : Name, Age and Subject ");
            }
        }

        public override void Describe()
        {
            Console.WriteLine(" I am a student ");
        }

        public override string GetOccupation()
        {
            return $" {Name} is  Student ";
        }
    }
}
