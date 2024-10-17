using Inheritance.Loggers;

namespace Inheritance;

public class ConsoleLogger : Logger
{
    public override void Log(string message)
    {
        Console.WriteLine(message);
    }
}