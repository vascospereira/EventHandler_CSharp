using System;

namespace EventHandlerProgram
{
    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime ReachedTime { get; set; }
    }
}