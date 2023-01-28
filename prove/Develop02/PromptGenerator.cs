using System;
using System.Collections.Generic;
public class PrompGenerator{
    public int _promptNumber;

    public string QuestionPrompt()
    {
        List<string> prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
        Random randomprompt = new Random();
        int randIndex = randomprompt.Next(prompts.Count);
        string random = prompts[randIndex];
        return random;

    }
    public void UniquePrompt()
    {
        
        
    }
}