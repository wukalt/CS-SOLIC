namespace DIPRef;

public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging: " + message);
    }
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.WriteAllText("log.txt", message);
    }
}

public class UserService
{
    private readonly ILogger _logger;

    /* it's depend on abstraction not a class */
    public UserService(ILogger logger)
    {
        _logger = logger;
    }

    public void RegisterUser(string username)
    {
        Console.WriteLine($"User {username} registered.");
        _logger.Log("User registered: " + username);
    }
}