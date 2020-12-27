using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BuilderDesignPattern
{
    public sealed class Person
    {
        public int Age { get; }
        public string Name { get; }
        public IReadOnlyCollection<string> Phones { get; }

        public Person() { }

        public Person(string name, int age, IReadOnlyCollection<string> phones)
        {
            Name = name;
            Age = age;
            Phones = phones;
        }
        public Person WithName(string name) => new Person(name, Age, Phones);

        public Person WithAge(int age) => new Person(Name, age, Phones);

        public Person WithPhones(IReadOnlyCollection<string> phones)
            => new Person(Name, Age, phones);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var jon = new Person(
                name: null,
                age: 30,
                phones: new ReadOnlyCollection<string>(new List<string>() { "1234", "45234" }));

            var realJon = jon.WithName("Jon Skeet")
                              .WithAge(35);
        }
    }
}
