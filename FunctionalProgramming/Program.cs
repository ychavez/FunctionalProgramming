using ExtensionMethods;
using System;

namespace Extensions
{
    class Program
    {
        /// <summary>
        /// implementation of a Extension method from datetime
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2020, 12, 12, 01, 02, 03);
            var result = dt1.ToDeviceFormat();
            Console.WriteLine(result);

            Console.ReadLine();

            DateTime dt2 = new DateTime(1999, 12, 12, 01, 02, 03);
            var result2 = dt2.ToDeviceFormat();
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
