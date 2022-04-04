using System;
using System.Collections.Generic;
using System.Threading;

namespace Assignment3.Utils
{
    public static class Visualizer
    {
        private static int mStep;
        private static int mDelayMilliSeconds = 100;
        private static bool mbEnabled;

        public static void Enable(int delayMilliSeconds)
        {
            mbEnabled = true;
            mDelayMilliSeconds = delayMilliSeconds;
        }

        public static void Disable()
        {
            mbEnabled = false;
        }

        public static void Init()
        {
            mStep = 0;
        }

        public static void Display(List<int>[] snapshot)
        {
            if (!mbEnabled || snapshot == null || snapshot.Length != 3)
            {
                return;
            }

            if (snapshot[0] == null || snapshot[1] == null || snapshot[2] == null)
            {
                return;
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Step: {mStep++}");
            Console.WriteLine();

            Console.WriteLine($"S: [ {string.Join(", ", snapshot[0])} ]");
            Console.WriteLine($"A: [ {string.Join(", ", snapshot[1])} ]");
            Console.WriteLine($"E: [ {string.Join(", ", snapshot[2])} ]");

            if (mDelayMilliSeconds > 0)
            {
                Thread.Sleep(mDelayMilliSeconds);
            }
        }
    }
}
