using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Pause(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}