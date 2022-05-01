using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathOperationService.Models
{
    public class NumericalDecomposition
    {
        public NumericalDecomposition(decimal number, List<decimal> divisorsNumbers, List<decimal> primeNumbers)
        {
            Number = number;
            DivisorsNumbers = divisorsNumbers;
            PrimeNumbers = primeNumbers;
        }

        public decimal Number { get; set; }
        public List<decimal> DivisorsNumbers { get; set; }
        public List<decimal> PrimeNumbers { get; set; }

    }
}
