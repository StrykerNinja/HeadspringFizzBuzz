using System;

namespace FizzBuzz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Awesome.FizzBuzzWriter.WriteFizzBuzz(1, 1000000000);

            Console.ReadLine();
        }
    }
}
