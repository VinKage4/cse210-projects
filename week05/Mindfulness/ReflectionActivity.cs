using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something hard.",
        "Think of a time you showed strength."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was it meaningful?",
        "How did you feel?",
        "What did you learn?"
    };

    private Random _random = new Random();

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This helps you reflect on meaningful experiences.")
    { }

    public void Run()
    {
        StartMessage();

        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);
        Pause(3);

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine(_questions[_random.Next(_questions.Count)]);
            Pause(4);
            time += 4;
        }

        EndMessage();
    }
}