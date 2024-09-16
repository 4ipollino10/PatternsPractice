namespace Observer.Subscribers;

public class EmailSubscriber
{
    public void Notify(string newTitle)
    {
        Console.WriteLine("NoReply.There is a new NEW:" + newTitle);
    }
}