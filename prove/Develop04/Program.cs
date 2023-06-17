using System;
using System.Diagnostics;
using System.Threading;

class Program
{
	static void Main(string[] args)
	{
		int duration = 0;
		string activityName;
		string activityDescription;
		bool quit = false;
		while (quit == false)
		{			
			Console.Clear();
			Console.WriteLine("Menu Options:\n\n" +
			"1. Start breathing activity\n" +
			"2. Start reflecting activity\n" + 
            "3. Start listing activity\n" +
			"4. Quit\n\n" +
			"Select a choice from the menu:");

			string userChoise = Console.ReadLine();
			Console.WriteLine("");
			switch(userChoise)
			{
				case "1":
				Console.Clear();
				activityName = "Breathing Activity";
				activityDescription = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
				
				BreathingActivity breathing = new BreathingActivity(activityName, activityDescription);
				Console.WriteLine(breathing.GetStartingMessage());
				duration = int.Parse(Console.ReadLine());
				Console.Clear();
				breathing.Spin("Get Ready", 5);
				breathing.Breathe(duration);
				breathing.Spin("\nWell Done!!\n", 2);
				breathing.Spin(breathing.GetEndingMessage(), 5);
				break;
				
                case "2":
				Console.Clear();
				activityName = "Relfection Activity";
				activityDescription = "reflect on times in your life when you have shown strength and resilience. " +
				"This will help you recognize the power you have and how you can use it in other aspects of your life.";
				ReflectionActivity reflection = new ReflectionActivity(activityName, activityDescription);				
				Console.WriteLine(reflection.GetStartingMessage());
				duration = int.Parse(Console.ReadLine());
				Console.Clear();
				reflection.Spin("Get Ready", 5);
				Console.WriteLine("Consider the following prompt:");
				Console.WriteLine($"--- {reflection.GetPrompt()} ---\n");
				Console.WriteLine("When you have something in mind, press enter to continue.");
				Console.ReadLine();
				reflection.Reflect(duration);
				reflection.Spin("\nWell Done!!\n", 2);
				reflection.Spin(reflection.GetEndingMessage(), 5);
				break;
				
                case "3":
				Console.Clear();
				activityName = "Relfection Activity";
				activityDescription = "reflect on the good things in your life by having you list as many things as you can in a certain area. ";
				ListingActivity listing = new ListingActivity(activityName, activityDescription);				
				Console.WriteLine(listing.GetStartingMessage());
				duration = int.Parse(Console.ReadLine());
				Console.Clear();
				listing.Spin("Get Ready", 5);
				listing.Listing(duration);
				listing.Spin("\nWell Done!!\n", 2);
				listing.Spin(listing.GetEndingMessage(), 5);
				break;
				
                case "4":
				quit = true;
				break;
				default:
				Console.WriteLine("That is not a valid response");
				Console.WriteLine("Hit any key to try again");
				string Input = Console.ReadLine();
				break;
			}
		}
	}
}