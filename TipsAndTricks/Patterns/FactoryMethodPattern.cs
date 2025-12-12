using TipsAndTricks.Patterns.Interfaces;

namespace TipsAndTricks.Patterns
{
    public class FactoryMethodPattern
    {
        abstract class NotificationFactory
        {
            public abstract INotificationFactory Create();
        }

        class EmailFactory : NotificationFactory
        {
            public override INotificationFactory Create() => new EmailNotification();
        }

        class SmsFactory : NotificationFactory
        {
            public override INotificationFactory Create() => new SmsNotification();
        }

        public FactoryMethodPattern()
        {
            var factory = new EmailFactory();
            var notifier = factory.Create();

            notifier.Send("Hello World!");
        }
    }
}
