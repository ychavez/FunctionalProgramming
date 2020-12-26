using System;
using System.Collections.Generic;
using System.Text;

namespace Inmutability.ShalloInwmutability
{

    public class Account
    {
        public string Name { get; }
        //list CouldBe inmutable
        public IReadOnlyCollection<string> EMails { get; }

        public Account(string name, IReadOnlyCollection<string> emails)
        {
            Name = name;
            EMails = emails;
        }

    }
    public class AccountClient
    {
        public static void Run()
        {
            var emails = new List<string>();
            var acc = new Account("NoName", emails);
        }
    }

}
