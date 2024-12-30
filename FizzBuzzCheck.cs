using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzCheck
    {
        public string GetFizzBuzz(int number)
        {

            if (number < 0)
            {
                return "Give a positive number";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();

        }
    }
}