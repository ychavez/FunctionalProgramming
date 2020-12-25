using System;

namespace LocalFunctions
{
    public class Customer
    {
        public string GetFullInfo(string fullStr)
        {
            return GetFullName(fullStr).firstName + GetFullName(fullStr).lastName;
            (string firstName, string lastName) GetFullName(string str) =>
                (str.Split()[0], str.Split()[1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
