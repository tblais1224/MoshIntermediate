using System;

namespace MoshIntermediate
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail.....");
        }
    }
}