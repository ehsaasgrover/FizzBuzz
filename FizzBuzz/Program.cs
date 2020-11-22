using System;

namespace FizzBuzz
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 1; i < 100; i++)
            {
                Console.WriteLine(FizzBuzzGenerator.Generate(i));
            }
        }

        
    }
}
