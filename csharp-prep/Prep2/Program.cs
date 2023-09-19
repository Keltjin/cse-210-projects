using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNum = int.Parse(grade);

        if (gradeNum >= 90)
        {
            
            Console.WriteLine("A");
        }
        else if (gradeNum >= 80)
        {
            Console.WriteLine("B");
        }
        else if (gradeNum >= 70)
        {
            Console.WriteLine("C");
        }
        else if (gradeNum >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}