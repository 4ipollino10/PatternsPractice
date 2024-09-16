namespace Observer;

public class NewsPublisher
{
    public delegate void Notify(string newTitle);

    public Notify Subscribe { get; set; }
    
    public event Notify? DoNotify;
    
    public void PublishNew(string newTitle, string newBody)
    {
        Console.WriteLine(newTitle + ":" + newBody);
        
        DoNotify?.Invoke(newTitle);
        
        Subscribe.Invoke(newTitle);
    }
}