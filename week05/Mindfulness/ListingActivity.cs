using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    private Random _random = new Random();

    public ListingActivity() 
        : base("Listing Activity",
        "his activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            
        };
    }

    public void Run()
{
    DisplayStartingMessage();

    string continueListing = "yes";

    while (continueListing.ToLower() == "yes")
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");

        Console.Write("\nDo you want another prompt? (yes/no): ");
        continueListing = Console.ReadLine();
    }

    DisplayEndingMessage();
}

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        return items;
    }
}