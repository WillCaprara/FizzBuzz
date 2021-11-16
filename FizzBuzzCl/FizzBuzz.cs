using FizzBuzzDll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzDll
{
    public class FizzBuzz
    {
        public StringBuilder Classic()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                bool multipleOf3 = MultipleOf(i, 3);
                bool multipleOf5 = MultipleOf(i, 5);

                if (multipleOf3 && multipleOf5)
                {
                    result.Append("FizzBuzz");
                }
                else if (multipleOf3)
                {
                    result.Append("Fizz");
                }
                else if (multipleOf5)
                {
                    result.Append("Buzz");
                }
                else 
                {
                    result.Append(i);
                }

                result.Append("\n");
            }

            return result;
        }

        public StringBuilder Advanced()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 12; i <= 145; i++)
            {
                bool multipleOf3 = MultipleOf(i, 3);
                bool multipleOf7 = MultipleOf(i, 7);
                bool multipleOf38 = MultipleOf(i, 38);

                if (multipleOf3 && multipleOf7 && multipleOf38)
                {
                    result.Append("FizzBuzzBazz");
                }
                else if (multipleOf3)
                {
                    result.Append("Fizz");
                }
                else if (multipleOf7)
                {
                    result.Append("Buzz");
                }
                else if (multipleOf38)
                {
                    result.Append("Bazz");
                }
                else
                {
                    result.Append(i);
                }

                result.Append("\n");
            }

            return result;
        }

        public StringBuilder CustomRange(int start, int end, List<DivisorTokenDto> divisorTokenDtos)
        {
            StringBuilder result = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                var token = GetTokenToPrint(i, divisorTokenDtos);

                result.Append(token);

                result.Append("\n");
            }

            return result;
        }

        public StringBuilder CustomSet(List<int> numbers, List<DivisorTokenDto> divisorTokenDtos)
        {
            StringBuilder result = new StringBuilder();

            foreach (var number in numbers)
            {
                var token = GetTokenToPrint(number, divisorTokenDtos);

                result.Append(token);

                result.Append("\n");
            }

            return result;
        }

        private bool MultipleOf(int currentNumber, int multipleOf)
        {
            return currentNumber % multipleOf == 0;
        }

        private string GetTokenToPrint(int currentNumber, List<DivisorTokenDto> divisorTokenDtos)
        {
            StringBuilder tokenForCurrentNumber = new StringBuilder();

            divisorTokenDtos.ForEach(item =>
            {
                if (currentNumber % item.Divisor == 0)
                {
                    tokenForCurrentNumber.Append(item.Token);
                }
            });

            if (tokenForCurrentNumber.Length == 0)
            {
                tokenForCurrentNumber.Append(currentNumber);
            }

            return tokenForCurrentNumber?.ToString();
        }
    }
}

