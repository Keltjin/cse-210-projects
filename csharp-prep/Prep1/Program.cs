using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        String last_name = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}