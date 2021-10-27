using System;
using System.Collections.Generic;
using FactorsLib;

using static System.Console;

namespace FactorsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine("Testing Factors Functionalities!!");
            // int[] primeFactors = Factors.PrimeFactors(30);
            // WriteLine($"the prime factors of 30 are {primeFactors}");

            funWithAnagrams(new List<string>(new []{"poke", "pkoe", "okpe", "ekop"}));
        }


        public static List<string> funWithAnagrams(List<string> text)
        {
            Console.WriteLine(text.Count);
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = i + 1; j < text.Count; j++)
                {
                    Console.WriteLine($"{i}-{j}");
                    Console.Write($"{text[i]}?={text[j]}");
                    if (isAnagram(text[i], text[j]))
                    {
                        Console.WriteLine("IS ANAGRAM");
                        text.RemoveAt(j);
                        j--;
                    }
                    Console.WriteLine();
                }
            }

            text.Sort();
            return text;
        }

        private static bool isAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            List<char> ls1 = new List<char>(s1.ToCharArray());
            List<char> ls2 = new List<char>(s2.ToCharArray());
            ls1.Sort();
            ls2.Sort();
            for (int i = 0; i < ls1.Count; i++)
            {
                if (ls1[i] != ls2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
