using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Desafio_Framework01
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new MathOperationsFacade();

            Console.WriteLine("Digite um numero: ");
            var input = Console.ReadLine();

            if (Regex.IsMatch(input, @"^[0-9]+$") && input.Length <= 18)
            {
                decimal number = Convert.ToDecimal(input);

                List<decimal> divisorsNumbers = new(facade.returnsDivisorsNumbers(number));
                List<decimal> primeNumbers = new(facade.returnsPrimeNumbers(divisorsNumbers));

                Console.WriteLine($"Numero de Entrada: {number}");
                
                Console.Write("Números divisores: ");
                divisorsNumbers.ForEach(number => Console.Write($"{number} "));
                Console.Write("\n");

                Console.Write("Divisores Primos: ");
                primeNumbers.ForEach(number => Console.Write($"{number} "));
                Console.Write("\n");
            }
            else
                Console.WriteLine("Favor digitar um numero inteiro, com até 18 caracteres.");
        }
    }
}
