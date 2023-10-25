using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts;

    public Random rand;

    
    public PromptGenerator()
    {
        this.prompts = new List<string> {"Who was the most intersting person I interacted with today?",
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How was I able to serve another person today?",
        "How did I improve myself today?"};

        this.rand = new Random();
    }

    public void DisplayPrompt()
    {
        int index = rand.Next(prompts.Count);
        string randomPrompt = prompts[index];

        Console.WriteLine(randomPrompt);   
    }
}