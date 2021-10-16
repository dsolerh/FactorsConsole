using System;
using FactorsLib;

using static System.Console;

namespace FactorsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Testing Factors Functionalities!!");
            int[] primeFactors = Factors.PrimeFactors(30);
            WriteLine($"the prime factors of 30 are {primeFactors}");
        }
    }
}
