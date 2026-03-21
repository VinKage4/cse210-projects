using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // 1. Added extra prompts beyond the minimum five.
        // 2. Added a mood field to each journal entry.
        // 3. Added input validation for menu choices.
        // 4. Save/load includes the mood field as well.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");

                string response = Console.ReadLine();

                Console.Write("How was your mood today? ");
                string mood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response, mood);
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please choose a number between 1 and 5.");
            }
        }
    }
}