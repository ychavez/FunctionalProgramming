using System;

namespace MutabilityOfStructures
{

    struct Mutable
    {

        public int X { get; private set; }
        public Mutable(int x) : this() => X = x;
        public int IncrementX() { X++; return X; }

    }
    /// <summary>
    /// bad desing example 
    /// </summary>
    class A
    {
        public Mutable PropertyMutable { get; }
        public readonly Mutable ReadOnlyMutable;
        public Mutable FieldMutable;
        public A()
        {
            PropertyMutable = new Mutable(x: 1);
            ReadOnlyMutable = new Mutable(x: 1);
            FieldMutable = new Mutable(x: 1);
        }
    }

    struct Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
        public Point Increment(int x, int y) => new Point(x, y);
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Property case");
            Console.WriteLine(a.PropertyMutable.IncrementX());
            Console.WriteLine(a.PropertyMutable.IncrementX());

            Console.WriteLine("ReadOnly case");
            Console.WriteLine(a.ReadOnlyMutable.IncrementX());
            Console.WriteLine(a.ReadOnlyMutable.IncrementX());

            Console.WriteLine("Field case");
            Console.WriteLine(a.FieldMutable.IncrementX());
            Console.WriteLine(a.FieldMutable.IncrementX());


            Console.Read();
        }
    }
}
