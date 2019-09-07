using System;

namespace MoshIntermediate
{
    public class VideoReadyForEncoding : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready for encoding....");
        }
    }
}