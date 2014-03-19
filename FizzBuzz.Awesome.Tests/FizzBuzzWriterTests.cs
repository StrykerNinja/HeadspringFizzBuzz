using NUnit.Framework;

namespace FizzBuzz.Awesome.Tests
{
    [TestFixture]
    public class FizzBuzzWriterTests
    {
        [Test]
        public void should_print_fizz_if_divisible_by_three()
        {
            // arrange
            var expected = new[] { "Fizz" };
            var rule = new Rule { Divisor = 3, Text = "Fizz" };

            // act
            var result = FizzBuzzWriter.EnumerateFizzBuzz(3, 3, new[] { rule });

            // assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void should_print_buzz_if_divisible_by_five()
        {
            // arrange
            var expected = new[] { "Buzz" };
            var rule = new Rule { Divisor = 5, Text = "Buzz" };

            // act
            var result = FizzBuzzWriter.EnumerateFizzBuzz(5, 5, new[] { rule });

            // assert
            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        public void should_print_fizzbuzz_if_divisible_by_both_three_and_five()
        {
            // arrange
            var expected = new[] { "FizzBuzz" };
            var rules = new[]
            {
                new Rule {Divisor = 5, Text = "Buzz"},
                new Rule {Divisor = 3, Text = "Fizz"}
            };

            // act
            var result = FizzBuzzWriter.EnumerateFizzBuzz(15, 15, rules);

            // assert
            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
