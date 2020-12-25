using System;

namespace PatternMatching
{
    public class Circle
    {
        public int Radius { get; set; }
    }
    public class Triangle
    {
        public int SideAB { get; set; }
        public int SideBC { get; set; }
        public int SideAC { get; set; }
    }
    class Program
    {
        static void SwitchCasePatternMatching(object o)
        {
            switch (o)
            {
                case Triangle t:
                    {
                        Console.WriteLine($"AB:{t.SideAB}");
                    }
                    break;
                case Circle c:
                    {
                        Console.WriteLine($"Radius:{c.Radius}");
                    }
                    break;
            }
        }
        static void StraightPatternMatching(object o)
        {
            if (o is int x || (o is string s && int.TryParse(s, out x)))
                Console.WriteLine($"X parsed with matching:{x}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
