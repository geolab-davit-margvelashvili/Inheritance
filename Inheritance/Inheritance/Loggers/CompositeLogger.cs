using Inheritance.Loggers;

namespace Inheritance;

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