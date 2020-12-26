using System;
using System.Collections.Generic;
using System.Text;

namespace Inmutability.Shallowmutability
{

    public class Account
    {
        public string Name { get; }
       //list CouldBe inmutable
        public List<string> EMails { get; }

        public Account(string name, List<string> emails)
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
            emails.Add("abc@gmail.com"); // still being mutable
        }
    }
}
