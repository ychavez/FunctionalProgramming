using System;
using System.Collections.Generic;
using System.Text;

namespace Inmutability.InMutable
{
    public class ValidityDateRange
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public ValidityDateRange(DateTime start, DateTime end)
        {
            if (start.CompareTo(End) > 0)
                throw new ArgumentException("End should be ahead of Start or equal.");

            Start = start;
            End = end;
        }
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
                validity = new ValidityDateRange(DateTime.Parse("2018-02-01"),
                                                  DateTime.Parse("2021-01-01"))

            };
            var date = DateTime.Parse("2021-01-02");

            bool result1 = card.validity.IsInEffect(date);
            Console.WriteLine($"card is in effect? {result1}");
            //Error because inmutability
            ///  card.validity.End = DateTime.Parse("2021-01-28");
             
            //Rihgt way
            card.validity = new ValidityDateRange(DateTime.Parse("2018-02-01"),
                                                  DateTime.Parse("2021-01-28"));
            bool result2 = card.validity.IsInEffect(date);
            Console.WriteLine($"card is in effect? {result2}");
        }
    }
}
