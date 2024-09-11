namespace Singleton;

public class Logger
{
    // ReSharper disable once InconsistentNaming
    private static Lazy<Logger> _logger => new Lazy<Logger>(() => new Logger());

    private Logger() { }

    public static Logger GetLogger()
    {
        return _logger.Value;
    }

    public void Information(string logString)
    {
        Console.WriteLine("[INF]:" + logString);
    }

    public void Error(string logString)
    {
        Console.WriteLine("[ERR]:" + logString);
    }
}