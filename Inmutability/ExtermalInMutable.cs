using System;
using System.Collections.Generic;
using System.Text;

namespace Inmutability.InMutable.Internal
{
    public class ValidityDateRange
    {
   
        public  DateTime Start { get; }
        public  DateTime End { get; } // readonly properties
        public ValidityDateRange(DateTime start, DateTime end)
        {
            if (start.CompareTo(End) > 0)
                throw new ArgumentException("End should be ahead of Start or equal.");

            Start = start;
            End = end;
        }
        public bool IsInEffect(DateTime date)
            => Start.CompareTo(date) <= 0 && End.CompareTo(date) >= 0;


        /// still mutable from inside if the properties is not readonly
      /*  public void Extend(int days) {
            End = End.AddDays(days);
        }*/


        // Rihgt way should return a new instance of ValidityRange Objects
        public ValidityDateRange Extend(int days) => new ValidityDateRange(Start, End.AddDays(days));

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
