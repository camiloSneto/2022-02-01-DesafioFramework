using System.Collections.Generic;

namespace MathFunctions
{
    interface IOperations
    {
        List<decimal> returnsDivisorsNumbers(decimal number);
        List<decimal> returnsPrimeNumbers(List<decimal> numbers);
    }
}
