using Inheritance.Loggers;

namespace Inheritance;

public class FileLogger : Logger
{
    public override void Log(string message)
    {
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}