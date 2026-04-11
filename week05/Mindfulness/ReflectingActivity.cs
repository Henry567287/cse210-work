using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity() 
        : base("Reflection Activity",
        "This activity helps you reflect on your strength and resilience.This will help you reflect on times in your life when you have shown strength and resilience. This can help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>()
        {
            "Think of a time you when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete.",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Think about this...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\n{question}");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }
}