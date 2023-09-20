using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number;
        string numText;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            numText = Console.ReadLine();
            number = int.Parse(numText);

            numbers.Add(number);
        } while (number != 0);

        // int total = numbers.Sum(x => Convert.ToInt32(x));
        // Console.WriteLine($"The sum is: {total}");

        int sum = 0;

        foreach (int numberList in numbers)
        {
            sum += numberList;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = -1;

        foreach (int numberList in numbers)
        {
            if (numberList > max)
            {
                max = numberList;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}