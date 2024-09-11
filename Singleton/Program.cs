using Singleton;

var logger1 = Logger.GetLogger();

logger1.Information("123");

var logger2 = Logger.GetLogger();

logger2.Error("123");

Console.WriteLine(logger1 == logger2);
