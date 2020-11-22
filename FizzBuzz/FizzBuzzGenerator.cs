namespace FizzBuzz
{
    public static class FizzBuzzGenerator
    {
        public static string Generate(int number)
        {
            if (IsMultipleOfFifteen(number)) return "FizzBuzz";
            if (IsMultipleOfThree(number)) return "Fizz";
            if (IsMultipleOfFive(number)) return "Buzz";
            return number.ToString();
        }

        private static bool IsMultipleOfFifteen(int number)
        {
            return IsMultipleOfThree(number) && IsMultipleOfFive(number);
        }

        private static bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }
        
    }
}