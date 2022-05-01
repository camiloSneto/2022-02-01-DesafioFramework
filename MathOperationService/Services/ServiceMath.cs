using MathOperationService.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathOperationService.Services
{
    public class ServiceMath : IServiceMath
    {
        private readonly MathOperationsFacade facade;

        public ServiceMath()
        {
            facade = new MathOperationsFacade();
        }

        public List<decimal> getAllDivisorsNumbers(decimal number)
        {
            return facade.returnsDivisorsNumbers(number);
        }

        public List<decimal> getAllPrimeNumbers(List<decimal> numbers)
        {
            return facade.returnsPrimeNumbers(numbers);
        }

        public bool isValid(decimal number)
        {
            if (Regex.IsMatch(Convert.ToString(number), @"^[0-9]+$") && Convert.ToString(number).Length <= 18)
                return true;

            return false;
        }
    }
}
