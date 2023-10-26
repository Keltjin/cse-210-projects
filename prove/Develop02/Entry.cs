using System;

public class Entry 
{
    public string userEntry;
    public List<string> entries;
    public List<DateTime> dates;

    public Entry()
    {
        this.entries = new List<string>{};
        this.userEntry = "";
        this.dates = new List<DateTime>{};
    }

    public string WriteEntry()
    {
        PromptGenerator prompt = new PromptGenerator{};
        prompt.DisplayPrompt();

        DateTime currentDate = DateTime.Now;

        userEntry = Console.ReadLine();

        dates.Add(currentDate);
        entries.Add(userEntry);
        
        return userEntry;
    }
}