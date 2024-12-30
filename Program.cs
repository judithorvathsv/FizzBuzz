using System;
using FizzBuzz;


class Program
{
    static void Main(string[] args)
    {
        var fizzBuzz = new FizzBuzzCheck();

        if (args.Length > 0)
        {
            foreach (var arg in args)
            {
                if (int.TryParse(arg, out int number))
                {                   
                    Console.WriteLine(fizzBuzz.GetFizzBuzz(number));
                }
                else
                {
                    Console.WriteLine("Give a valid number.");
                }
            }
        }


    }


}
