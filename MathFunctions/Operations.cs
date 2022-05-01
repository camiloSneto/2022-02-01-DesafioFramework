using System;
using System.Collections.Generic;

namespace MathFunctions
{
    public class Operations: IOperations
    {
        public List<decimal> returnsDivisorsNumbers(decimal number)
        {
            List<decimal> divisorsNumbers = new List<decimal>();

            for (decimal i = 1; i * i < number; i++)
            {
                if (number % i == 0)
                    divisorsNumbers.Add(i);
            }

            for (decimal i = (int)Math.Sqrt((double)number); i >= 1; i--)
            {
                if (number % i == 0)
                    divisorsNumbers.Add(number / i);
            }
            return divisorsNumbers;
        }
        public List<decimal> returnsPrimeNumbers(List<decimal> numbers)
        {
            List<decimal> primeNumbers = new List<decimal>();
            numbers.ForEach(number => {
                if (isPrime(number))
                    primeNumbers.Add(number);
            });

            return primeNumbers;
        }
        private bool isPrime(decimal number)
        {
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt((double)number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

    }
}
