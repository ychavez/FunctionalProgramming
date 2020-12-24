using System;

namespace Autoproperties
{

    public class Character
    {

        public int Armor { get; } = 100;

        ///  public int Armor  => 100; still being inmutable
        ///  public int Armor  = 100; !!! be carefull with that!!!

        public int Wear { get; private set; } = 15;
        public int Healt { get; private set; } = 100;

        ///ExpressiBonbody function
        public int Defense => Wear >= Armor ? 0 : Armor - Wear;

        public void Damage(int damage) => Healt -= damage - Defense;

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
