using System;

namespace Autoproperties
{

    public class Character {

        public int Armor { get; } = 100;

        public Character()
        {
            Armor = 90;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            Console.WriteLine(c.Armor);
            //look how constructor has the priority
            Console.ReadLine();
        }
    }
}
