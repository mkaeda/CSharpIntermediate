using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    class StopWatch
    {
        private DateTime _start;
        private Boolean started;
        
        public void Start()
        {
            if (started)
            {
                throw new InvalidOperationException("stopwatch already started");
            }
            _start = DateTime.Now;
            started = true;
        }

        public TimeSpan Stop()
        {
            if (!started)
            {
                throw new InvalidOperationException("stopwatch not started");
            }
            var duration = DateTime.Now - _start;
            started = false;
            return duration;
        }
    }
}
