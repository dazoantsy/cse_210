using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generatedPrompt = new PromptGenerator();
        int choice = 0;

        Console.Write("Welcome to the Journal Program!");

        while (choice != 5)
        {
        Console.Write("\nPlease select one of the following choices:\n");
        Console.Write("1. Write\n");
        Console.Write("2. Display\n");
        Console.Write("3. Load\n");
        Console.Write("4. Save\n");
        Console.Write("5. Quit\n");
        Console.Write("\nWhat would you like to do? ");
        string userInput = Console.ReadLine();
        choice = int.Parse(userInput);
            switch (choice)
            {
                case 1:
                string dateInfo = GetDateTime();
                string prompt = generatedPrompt.GetPrompt();
                Entry entry = new Entry();
                entry._time = dateInfo;
                entry._prompt = prompt;
                Console.Write($"{prompt}\n");
                Console.Write("--> ");
                string userEntry = Console.ReadLine();
                entry._entry = userEntry;
                journal._journal.Add(entry);
                Console.Clear();
                break;
                case 2:
                journal.Display();
                break;
                case 3:
                journal.LoadFile();
                break;
                case 4:
                journal.CreateFile();
                break;
                case 5:
                Console.WriteLine("\nThanks for using the Journal Program!\n");
                break;
                default:
                Console.WriteLine("\nInvalid Input!");
                break;
            }
        }
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToShortDateString();
        return currentDateTime;
    }
}