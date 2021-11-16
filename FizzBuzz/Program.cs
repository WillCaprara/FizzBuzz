using System;
using System.Collections.Generic;
using FizzBuzzDll;
using FizzBuzzDll.Models;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();

            var resultClassic = fizzBuzz.Classic();
            //Console.WriteLine(resultClassic.ToString());

            //-----

            var resultAdvanced = fizzBuzz.Advanced();
            //Console.WriteLine(resultAdvanced.ToString());

            //-----

            var divisorTokenDtosCustomRange = new List<DivisorTokenDto>()
            {
                new DivisorTokenDto
                {
                    Divisor = 6,
                    Token = "Foo"
                },
                new DivisorTokenDto
                {
                    Divisor = 7,
                    Token = "Bar"
                },
                new DivisorTokenDto
                {
                    Divisor = 42,
                    Token = "Bazz"
                }
            };

            var resultCustomRange = fizzBuzz.CustomRange(1, 100, divisorTokenDtosCustomRange);
            //Console.WriteLine(resultCustomRange.ToString());

            //-----

            var customSet = new List<int> { 8, 2574, 286, 287, 234, 1980, 23166000, 23166142 };

            var divisorTokenDtosCustomSet = new List<DivisorTokenDto>()
            {
                new DivisorTokenDto
                {
                    Divisor = 9,
                    Token = "Bing"
                },
                new DivisorTokenDto 
                {
                    Divisor = 11,
                    Token = "Bang"
                },
                new DivisorTokenDto
                {
                    Divisor = 13,
                    Token = "Boom"
                }
            };

            var resultCustomSet = fizzBuzz.CustomSet(customSet, divisorTokenDtosCustomSet);
            //Console.WriteLine(resultCustomSet.ToString());
        }
    }
}
