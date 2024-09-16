using Observer;
using Observer.Subscribers;

var emailSub = new EmailSubscriber();
var smsSub = new SMSSubscriber();

var newsPublisher = new NewsPublisher();

newsPublisher.DoNotify += smsSub.Notify;
newsPublisher.DoNotify += emailSub.Notify;

newsPublisher.PublishNew("WOW THAT IS ILLEGAL", "omg");