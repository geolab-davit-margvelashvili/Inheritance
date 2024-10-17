namespace Inheritance;

public abstract class Vehicle
{
    protected string Name { get; }

    protected Vehicle(string name)
    {
        Name = name;
    }

    public void Start()
    {
        Console.WriteLine($"{Name} Started...");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} Stopped...");
    }

    public abstract void Drive();
}

public class Car : Vehicle
{
    public Car(string name) : base(name)
    {
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving {Name} on 4 wheel");
    }
}

public sealed class Motorcycle : Vehicle
{
    public Motorcycle() : base("Moto")
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Driving on 2 wheel");
    }
}

public interface IFlyingObject
{
    void Fly();
}

public class Plane : Vehicle, IFlyingObject
{
    public Plane() : base("Plane")
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Driving only in airport");
    }

    public void Fly()
    {
        Console.WriteLine("Plane is Flying....");
    }
}

public class Bird : IFlyingObject
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying...");
    }
}

public class Pilot
{
    public IFlyingObject FlyingObject { get; set; }

    public void FlyObject()
    {
        if (FlyingObject != null)
        {
            FlyingObject.Fly();
        }
    }
}

public class Soldier
{
    public Vehicle Vehicle { get; set; }

    public void DriveVehicle()
    {
        if (Vehicle is not null)
        {
            Vehicle.Drive();
        }
    }
}

public interface ICSharpDeveloper
{
    public void WriteCode();
}

public interface IJavaDeveloper
{
    public void WriteCode();
}

public class Employee : IJavaDeveloper, ICSharpDeveloper
{
    void IJavaDeveloper.WriteCode()
    {
        Console.WriteLine("Writing Java code");
    }

    void ICSharpDeveloper.WriteCode()
    {
        Console.WriteLine("Writing C# code");
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        IJavaDeveloper javaDev = emp;
        javaDev.WriteCode();

        ICSharpDeveloper csharpDev = emp;
        csharpDev.WriteCode();

        var car = new Car("Car");
        var moto = new Motorcycle();
        var plane = new Plane();
        var bird = new Bird();

        var soldier = new Soldier();
        soldier.Vehicle = car;
        soldier.DriveVehicle();

        soldier.Vehicle = moto;
        soldier.DriveVehicle();

        soldier.Vehicle = plane;
        soldier.DriveVehicle();

        var pilot = new Pilot();
        pilot.FlyingObject = plane;
        pilot.FlyObject();

        pilot.FlyingObject = bird;
        pilot.FlyObject();

        var numbersList = new List<int> { 1, 2, 3, 4 };
        var numbersArray = new[] { 1, 2, 3, 4 };
        Sum(numbersList);

        Sum(numbersArray);

        Console.WriteLine();
    }

    public static int Sum(IEnumerable<int> numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}