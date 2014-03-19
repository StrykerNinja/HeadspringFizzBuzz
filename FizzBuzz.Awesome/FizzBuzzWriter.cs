using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Awesome
{
    public static class FizzBuzzWriter
    {
        public static void WriteFizzBuzz()
        {
            WriteFizzBuzz(1, 100);
        }

        public static void WriteFizzBuzz(int min, int max)
        {
            var rules = new[]
            {
                new Rule {Divisor = 3, Text = "Fizz"},
                new Rule {Divisor = 5, Text = "Buzz"}
            };

            foreach (var value in EnumerateFizzBuzz(min, max, rules))
            {
                Console.WriteLine("{0}", value);
            }
        }

        public static IEnumerable<string> EnumerateFizzBuzz(int min, int max, IList<Rule> rules)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException("min");
            }

            for (int i = min; i <= max; i++)
            {
                yield return string.Join(string.Empty, rules.OrderBy(r => r.Divisor).Where(r => i%r.Divisor == 0).Select(r => r.Text).DefaultIfEmpty(string.Format("{0}", i)));
            }
        }
    }
}
