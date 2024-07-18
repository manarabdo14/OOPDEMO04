using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgnment
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
        }
    }
}
