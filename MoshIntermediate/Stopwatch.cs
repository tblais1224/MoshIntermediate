using System;

namespace MoshIntermediate
{
    public class Stopwatch
    {
        private DateTime _stopwatchStart;

        private bool _running;
        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("stopwatch running already");
            }
            _running = true;
            _stopwatchStart = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            _running = false;
            return DateTime.Now - _stopwatchStart;
        }
    }
}