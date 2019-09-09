using System;

namespace MoshIntermediate
{
    public class MoshStopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _running = false;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("stopwatch already running");
            }
            _startTime = DateTime.Now;
            _running = true;

        }

        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("stopwatch is not running");
            }
            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }

    }
}