namespace SRP;

internal class FirstDraft
{
    static void ActivateAccount()
    {
        // get email from user
        var userEmail = Console.ReadLine()!;

        try
        {
            SendEmail(userEmail);
        }
        catch (Exception e)
        {
            // if we can't send email we log it into a file 

            var dateTime = DateTime.Now;
            var logPath = $"/logs/log-{dateTime}.txt";

            using StreamWriter writer = new(logPath);
            writer.Write(e.Data);
            writer.Close();
            throw;
        }
    }

    static void SendEmail(string inputEmail)
    {
        // logic for send email to {inputEmail} 
    }
}