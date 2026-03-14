using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best thing that happened today?",
        "What did you learn today?",
        "Who did you help today?",
        "What made you smile today?",
        "What challenge did you overcome today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
