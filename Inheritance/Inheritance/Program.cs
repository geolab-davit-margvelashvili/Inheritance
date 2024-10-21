using Inheritance.Game;
using System.Collections.Generic;

namespace Inheritance;

public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student("Nika", 27, 1);
        var teacher = new Teacher("Lia", 47, "Mathematics");

        student.DisplayInfo();
        student.Describe();
        teacher.DisplayInfo();
        teacher.Describe();
        Console.WriteLine(student.GetOccupation());
        Console.WriteLine(teacher.GetOccupation());
        Console.WriteLine();

        Weapon axe = new Axe("Axe", 140);

        Weapon bow = new Bow("Bow", 15);
        Weapon sword = new Sword("Sword", 25);


        var kratos = new Character("Kratos", new List<Weapon> { axe, sword });


        var altair = new Character("Altair", new List<Weapon> { bow, sword });


        kratos.Hit(bow, altair);
        kratos.Hit(sword, altair);
        altair.Hit(axe, kratos);
        altair.Hit(bow, kratos);
        altair.Hit(sword, altair);
        kratos.Hit(axe, altair);
        altair.Hit(bow, kratos);


    }
}