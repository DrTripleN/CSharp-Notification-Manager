using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301231884_Needham__Lab2
{
    public class NotificationManager
    {
        public delegate void NotificationHandler(string message);

        public event NotificationHandler NotificationPublished;

        public void PublishNotification(string message)
        {
            NotificationPublished?.Invoke(message);

        }
    }
}
