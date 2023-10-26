using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string journal;
        string journal2;

        Entry userEntry = new Entry();
        journal = userEntry.WriteEntry();
        journal2 = userEntry.WriteEntry();

        for (int i = 0; i <userEntry.dates.Count; i++)
        {
            Console.WriteLine(userEntry.dates[i]);
            Console.WriteLine(userEntry.entries[i]);
        }
    }
}