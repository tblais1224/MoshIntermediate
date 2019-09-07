using System.Collections.Generic;

namespace MoshIntermediate
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {

            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }
    }
}