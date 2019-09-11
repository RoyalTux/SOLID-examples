using DependencyInversionPrinciple.Interface;

namespace DependencyInversionPrinciple.Class
{
    public class Notification
    {
        private readonly IMessage _message;

        public Notification(IMessage message) => _message = message;

        public string GetEmail() => _message.SendMessage();

        public string GetSms() => _message.SendMessage();
    }
}
