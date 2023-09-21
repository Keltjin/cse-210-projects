using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNum = PromptUserNumber();
        int squared = SquareNumber(userNum);
        DisplayResult(username, squared);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your USERNAME? ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string numText = Console.ReadLine();
        int userNum = int.Parse(numText);
        return userNum;
    }

    static int SquareNumber(int userNum)
    {
        int squared = userNum * userNum;
        return squared;
    }

    static void DisplayResult(string username, int squared)
    {
        Console.WriteLine($"Username: {username}, Squared Number: {squared}");
    }
}