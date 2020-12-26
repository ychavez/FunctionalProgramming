using System;
using System.Collections.Generic;
using System.Text;

namespace Inmutability.PopsicleInmutability
{
    public sealed class Popsicle
    {
        public bool Frozen { get; private set; }
        private int value;
        public int Value
        {
            get => value; set
            {
                if (Frozen)
                    throw new InvalidOperationException("Couldn't keep in it, heaven knows I tried");

                this.value = value;
            }
        }
        public void Freeze()
        {
            Frozen = true;
        }

    }
    public class PopsicleClient
    {
        public static void Run()
        {
            var popsicle = new Popsicle();
            popsicle.Value = 1;
            popsicle.Value = 2;
            popsicle.Freeze();
            //Exception!
            popsicle.Value = 2;
        }
    }
}
