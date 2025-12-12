namespace TipsAndTricks.Patterns.Interfaces
{
    public interface INotificationFactory
    {
        void Send(string message);
    }

    public class EmailNotification : INotificationFactory
    {
        public EmailNotification() { }

        void INotificationFactory.Send(string message)
        {
            throw new NotImplementedException();
        }
    }

    public class SmsNotification : INotificationFactory
    {
        public SmsNotification() { }

        void INotificationFactory.Send(string message)
        {
            throw new NotImplementedException();
        }
    }
}