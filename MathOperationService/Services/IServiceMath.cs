using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathOperationService.Services
{
    public interface IServiceMath
    {
        public List<decimal> getAllDivisorsNumbers(decimal number);
        public List<decimal> getAllPrimeNumbers(List<decimal> numbers);
        bool isValid(decimal number);
    }
}
