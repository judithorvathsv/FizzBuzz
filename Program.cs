using System;
using FizzBuzz;

class Program
{
    public static void GetResult(string[] input)
    {
        FizzBuzzCheck fizzBuzz = new FizzBuzzCheck();

        foreach (var arg in input)
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

    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            bool sort = args.Contains("--sort");

            var inputNumbers = args.Where(arg => arg != "--sort").ToArray();

            if (sort)
            {
                var sortedNumbers = inputNumbers
                    .Select(int.Parse)
                    .OrderBy(n => n)
                    .Select(n => n.ToString())
                    .ToArray();

                GetResult(sortedNumbers);
            }
            else
            {
                GetResult(args);
            }
        }
    }
}
