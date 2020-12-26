using System;
using System.Collections.Generic;
using System.Text;

namespace Inmutability.Mutable
{

    public class ValidityDateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsInEffect(DateTime date)
            => Start.CompareTo(date) <= 0 && End.CompareTo(date) >= 0;

    }
    public class Card
    {
        public string SerialNunmber { get; set; }
        public ValidityDateRange validity { get; set; }
    }
    public class RangeClient
    {
        public static void Test()
        {
            var card = new Card
            {
                SerialNunmber = "123",
                validity = new ValidityDateRange()
                {
                    Start = DateTime.Parse("2018-02-01"),
                    End = DateTime.Parse("2021-01-01")
                }
            };
            var date = DateTime.Parse("2021-01-02");

            bool result1 = card.validity.IsInEffect(date);
            Console.WriteLine($"card is in effect? {result1}");

            card.validity.End = DateTime.Parse("2021-01-28");
            bool result2 = card.validity.IsInEffect(date);
            Console.WriteLine($"card is in effect? {result2}");
        }
    }
}
