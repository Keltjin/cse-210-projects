using System;

class Program
{
    static void Main(string[] args)
    {
        string journal;
        string journal2;

        Entry userEntry = new Entry();
        journal = userEntry.WriteEntry();

        Entry userEntry2 = new Entry();
        journal2 = userEntry2.WriteEntry();

        Console.WriteLine(journal);
        Console.WriteLine(journal2);
    }
}