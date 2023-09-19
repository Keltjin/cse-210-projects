using System;

class Program
{
    static void Main(string[] args)
    {
        string replay = "";

        while (replay != "no")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
        
            string guessText;
            int guessNum;

            do
            {
                Console.Write("What is your guess? ");
                guessText = Console.ReadLine();
                guessNum = int.Parse(guessText);

                if (guessNum < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNum > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (guessNum != number);

            Console.Write("Do you want to play again? ");
            replay = Console.ReadLine();
        }
    }
}