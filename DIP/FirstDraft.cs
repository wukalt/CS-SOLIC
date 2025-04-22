namespace DIP;

public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging: " + message);
    }
}

public class UserService
{
    /* it's depend on logger class and if we have 
     another logger for this class we need to rewrite this */
    private readonly Logger _logger;

    public UserService(Logger logger)
    {
        _logger = logger;
    }

    public void RegisterUser(string username)
    {
        Console.WriteLine($"User {username} registered.");

        _logger.Log("User registered: " + username);
    }
}