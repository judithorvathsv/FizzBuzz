using System;
using FizzBuzz;


class Program
{
    static void Main(string[] args)
        {
          
        if (args.Length > 0 && int.TryParse(args[0], out int number))
        {
           
            var fizzBuzz = new FizzBuzzCheck();            
           
            Console.WriteLine(fizzBuzz.GetFizzBuzz(number));
        }
        else
        {
            Console.WriteLine("Give a valid number.");
        }
    }


}
