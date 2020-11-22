using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGeneratorShould
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("4", 4)]
        [InlineData("7", 7)]
        public void GenerateNumberAsStringGivenNonMultiple(string expected, int number)
        {
            // Arrange

            // Act
            var actual = FizzBuzzGenerator.Generate(number);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void GenerateFizzGivenMultipleOfThreeNotFive(int number)
        {
            // Arrange

            // Act
            var actual = FizzBuzzGenerator.Generate(number);

            // Assert
            Assert.Equal("Fizz", actual);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void GenerateBuzzGivenMultipleOfFiveNotThree(int number)
        {
            // Arrange

            // Act
            var actual = FizzBuzzGenerator.Generate(number);

            // Assert
            Assert.Equal("Buzz", actual);
        }
        
        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void GenerateFizzBuzzGivenMultipleOfFifteen(int number)
        {
            // Arrange

            // Act
            var actual = FizzBuzzGenerator.Generate(number);

            // Assert
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
