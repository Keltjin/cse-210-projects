using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade);

        string letter = "";
        
        if (gradeNum >= 90)
        {
            letter = "A";
        }
        else if (gradeNum >= 80)
        {
            letter = "B";
        }
        else if (gradeNum >= 70)
        {
            letter = "C";
        }
        else if (gradeNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradeNum >= 70)
        {
            Console.WriteLine("You passed! Great job!");
        }
        else
        {
            Console.WriteLine("Get some help and you can pass next time.");
        }

        Console.WriteLine(letter);
    }
}