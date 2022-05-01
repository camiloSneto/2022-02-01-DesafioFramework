using System.Collections.Generic;
using MathFunctions;

namespace MathOperationService.Facades
{
    public class MathOperationsFacade
    {
        private readonly Operations _Operations;

        public MathOperationsFacade()
        {
            _Operations = new Operations();
        }

        public List<decimal> returnsDivisorsNumbers(decimal number)
        {
            return _Operations.returnsDivisorsNumbers(number);
        }
        public List<decimal> returnsPrimeNumbers(List<decimal> numbers)
        {
            return _Operations.returnsPrimeNumbers(numbers);
        }

    }
}
