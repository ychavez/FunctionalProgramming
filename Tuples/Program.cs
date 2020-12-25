using System;

namespace Tuples
{
    public class RocketLauncher {
        public (int mainSystemError, int subSystemError) LaunchRocket() {
            Launch();
            return (GetMainSystemState(), GetSubsystemState());
        }

        private int GetSubsystemState()
        {
            return 0;
        }

        private int GetMainSystemState()
        {
            return 0;
        }

        private void Launch()
        {
            
        }
    }

    public class Point {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Deconstruction(out int x, out int y) {
            x = X;
            y = Y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RocketLauncher launcher = new RocketLauncher();
            var results = launcher.LaunchRocket();
            Console.WriteLine(results.mainSystemError);
            Console.WriteLine(results.subSystemError);
            (int first1, int second1) = launcher.LaunchRocket();
            (var first2, var second2) = launcher.LaunchRocket();
            var (first3, second3) = launcher.LaunchRocket();
        }
    }
}
