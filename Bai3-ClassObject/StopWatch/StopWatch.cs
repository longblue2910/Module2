using System;
namespace BT_stop_watch
{
    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;
        public void Star()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public double GetTimeDoing()
        {
            return (endTime - startTime).TotalMilliseconds;
        }
    }
}
