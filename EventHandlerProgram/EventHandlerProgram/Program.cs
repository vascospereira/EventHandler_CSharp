using System;

namespace EventHandlerProgram
{
    internal static class Program
    {
        private static bool _thresholdNotReached = true;
        private static void Main()
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += OnThresholdReached;

            Console.WriteLine("Press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a' && _thresholdNotReached)
            {
                Console.WriteLine("Adding One...");
                c.Add(1);
            }
        }

        private static void OnThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"The threshold of {e.Threshold} was reached at {e.ReachedTime}");
            _thresholdNotReached = false;
        }
    }
}
