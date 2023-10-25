using System;

public class Entry 
{
    public string userEntry;
    public List<string> Entries;

    public Entry()
    {
        this.Entries = new List<string>{};
        this.userEntry = "";
    }

    public string WriteEntry()
    {
        PromptGenerator prompt = new PromptGenerator{};
        prompt.DisplayPrompt();

        userEntry = Console.ReadLine();
        
        return userEntry;
    }
}