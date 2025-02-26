namespace SOLID.DependencyInversionPrinciple_DIP
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            // Send email logic
        }
    }

    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void SendNotification(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}
