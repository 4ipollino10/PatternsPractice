namespace Observer.Subscribers;

// ReSharper disable once InconsistentNaming
public class SMSSubscriber
{
    public void Notify(string newTitle)
    {
        Console.WriteLine("SMS.There is a new NEW:" + newTitle);
    }
}