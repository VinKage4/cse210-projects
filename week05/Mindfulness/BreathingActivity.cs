using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by focusing on breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(3);
            Console.WriteLine("Breathe out...");
            Pause(3);

            time += 6;
        }

        EndMessage();
    }
}