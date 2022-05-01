using System;
using System.Collections.Generic;
using Xunit;
using MathFunctions;

namespace MathFunctionsTester
{
    public class OperationsTests
    {
        [Theory]
        [InlineData(new string[] { "1", "3", "5", "9", "15", "45" }, "45")]
        [InlineData(new string[] { "1", "2", "4", "8", "16", "32", "64", "128" }, "128")]
        [InlineData(new string[] { "1", "7", "49" }, "49")]
        [InlineData(new string[] { "1", "7" }, "7")]
        public void Return_All_Divisors_Numbers(string[] inputResult, string inputNumber)
        {
            //Arrange
            var number = Convert.ToDecimal(inputNumber);
            decimal[] result = Array.ConvertAll<string, decimal>(inputResult, Convert.ToDecimal);
            var operations = new Operations();

            var divisorsNumbers = new List<decimal>();
            divisorsNumbers.AddRange(result);

            //Act
            var operation = operations.returnsDivisorsNumbers(number);

            //Assert
            Assert.Equal(divisorsNumbers, operation);
        }

        [Theory]
        [InlineData(new string[] { "1", "3", "5", "9", "15", "45" }, new string[] { "1", "3", "5" })]
        [InlineData(new string[] { "1", "2", "4", "8", "16", "32", "64", "128" }, new string[] { "1", "2" })]
        [InlineData(new string[] { "1", "7", "49" }, new string[] { "1", "7" })]
        [InlineData(new string[] { "1", "7" }, new string[] { "1", "7" })]
        public void Return_All_Prime_Numbers(string[] inputNumbers, string[] inputResult)
        {
            //Arrange
            var operations = new Operations();

            decimal[] numbers = Array.ConvertAll<string, decimal>(inputNumbers, Convert.ToDecimal);
            var divisorsNumbers = new List<decimal>();
            divisorsNumbers.AddRange(numbers);

            decimal[] result = Array.ConvertAll<string, decimal>(inputResult, Convert.ToDecimal);
            var primeNumbersResult = new List<decimal>();
            primeNumbersResult.AddRange(result);

            //Act
            var operation = operations.returnsPrimeNumbers(divisorsNumbers);

            //Assert
            Assert.Equal(primeNumbersResult, operation);
        }
    }
}
