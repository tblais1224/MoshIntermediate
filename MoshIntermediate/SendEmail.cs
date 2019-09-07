using System;

namespace MoshIntermediate
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email....");
        }
    }
}