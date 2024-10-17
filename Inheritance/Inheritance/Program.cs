using Inheritance.Models;

namespace Inheritance;

//S - Single responsibility
//
//O - Open for extensions -Close for modifications
//
//L I D

public abstract class Logger
{
    public abstract void Log(string message);
}

public class FileLogger : Logger
{
    public override void Log(string message)
    {
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}

public class ConsoleLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class CompositeLogger : Logger
{
    private readonly FileLogger _fileLogger;
    private readonly ConsoleLogger _consoleLogger;

    public CompositeLogger(FileLogger fileLogger, ConsoleLogger consoleLogger)
    {
        _fileLogger = fileLogger;
        _consoleLogger = consoleLogger;
    }

    public override void Log(string message)
    {
        _fileLogger.Log(message);
        _consoleLogger.Log(message);
    }
}

public class Program
{
    public static void Main()
    {
        Logger logger = new FileLogger();

        logger.Log("Manager object created");

        var manager = new Manager
        {
            BirthDate = new DateTime(1996, 10, 11),
            Salary = 4500m,
            DepartmentName = "Finance",
            Name = "Levani"
        };

        logger.Log("lecturer object created");

        var lecturer = new Lecturer
        {
            BirthDate = new DateTime(1994, 10, 11),
            Salary = 4600m,
            Subject = "C#",
            Name = "Daviti"
        };

        logger.Log("it object created");

        var it = new SupportMember()
        {
            BirthDate = new DateTime(1994, 10, 11),
            Salary = 3500,
            Field = "It Support",
            Name = "Giorgi"
        };

        List<Employee> employees = new List<Employee>
        {
            manager,
            lecturer,
            it
        };

        Employee emp = new Lecturer();

        var totalAmount = 0m;
        foreach (Employee employee in employees)
        {
            logger.Log("Calculating salary");
            totalAmount += employee.CalculateSalary(100);
        }

        Console.WriteLine();
    }
}