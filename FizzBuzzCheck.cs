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

            else if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }

            else if (number % 3 == 0)
            {
                return "Fizz";
            }

            else if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();

        }
    }
}