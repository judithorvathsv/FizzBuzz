using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzCheck
    {
        public string GetFizzBuzz(int number){

            if(number<0){
                return "Give a positive number";
            }

            return number.ToString();

        }
    }
}