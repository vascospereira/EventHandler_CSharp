using System;

namespace EventHandlerProgram
{
    internal class Counter
    {
        private readonly int _threshold;
        private int _total;

        public Counter(int threshold)
        {
            _threshold = threshold;
        }

        public void Add(int value)
        {
            _total += value;

            if (_total < _threshold) return;

            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs
            {
                Threshold = _total,
                ReachedTime = DateTime.Now
            };

            OnThresholdReached(args);
        }

        private void OnThresholdReached(ThresholdReachedEventArgs args)
        {
            ThresholdReached?.Invoke(this, args);
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }
}
