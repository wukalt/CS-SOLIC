namespace SRP;

internal class Refactored
{
    void ActivateAccount()
    {
        // get email from user
        var userEmail = Console.ReadLine()!;

        try
        {
            SendEmail(userEmail);
        }
        catch (Exception e)
        {
            // use logger class for seperate the responsibilities
            Logger.Log(e);
            throw;
        }
    }

    static void SendEmail(string inputEmail)
    {
        // logic for send email to {inputEmail} 
    }
}

// it's better to put this class into a seperate file
internal class Logger
{
    public static void Log(Exception e)
    {
        var dateTime = DateTime.Now;
        var logPath = $"/logs/log-{dateTime}.txt";

        using StreamWriter writer = new(logPath);
        writer.Write(e.Data);
        writer.Close();
    }
}