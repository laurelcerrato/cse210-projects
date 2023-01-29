using System;
using System.Collections.Generic;
public class PrompGenerator{
    public string QuestionPrompt()
    {
        List<string> prompts = new List<string>(){
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What brings you joy?",
            "Describe a place where you felt happiest.",
            "What was your greatest fear, and how did you conquer it?",
            "Describe your dream job/partner/house.",
            "Where is one place that you would like to visit, and how do you imagine your time there?",
            "If you are granted a wish, what would you wish for and why?",
            "If you are a superhero, what superpower would you like to have and how would you use it?",
            "Where do you see yourself in the next 1, 3, 5, 10 years from now?",
            "What is something that you would like to achieve? How do you plan on reaching your goal(s)?",
            "How could you make someone you care about feel better if he/she just lost something important to them?",
                    };
        Random randomprompt = new Random();
        int randIndex = randomprompt.Next(prompts.Count);
        string random = prompts[randIndex];
        return random;
    }

}