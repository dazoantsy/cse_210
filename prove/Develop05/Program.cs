using System;
class Program
{
    static void Main(string[] args)
    {
        List<string> goal = new List<string>();
        List<Goal> goals = new List<Goal>();
        int points = 0;
        bool quit = false;
		while (quit == false)
		{
            Menu menu = new Menu();
            //Console.Clear();
            Console.WriteLine(menu.DisplayPoints(points));
            Console.WriteLine();
            menu.DisplayMainMenu();
            string userChoise = menu.GetUserResponse("Select a choice from the menu");
			Console.WriteLine("");
			switch(userChoise)
            {
                case "1":
                Console.Clear();
                menu.DisplayGoalTypeMenu();
                string goalType = menu.GetUserResponse("Which type of goal would you like to create?");
                while (goalType != "1" && goalType != "2" && goalType != "3")
                {
                    menu.DisplayGoalTypeMenu();
                    goalType = menu.GetUserResponse("Which type of goal would you like to create?");
                }
                if (goalType == "1")
                {
                    string goalName = menu.GetUserResponse("What is the name of your goal?");
                    string goalDescription = menu.GetUserResponse("What is a short description of it?");
                    string expectedPoints = menu.GetUserResponse("What is the amount of points associated with this goal?");

                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, expectedPoints);
                    goals.Add(simpleGoal);

                }
                if (goalType == "2")
                {
                    string goalName = menu.GetUserResponse("What is the name of your goal?");
                    string goalDescription = menu.GetUserResponse("What is a short description of it?");
                    string expectedPoints = menu.GetUserResponse("What is the amount of points associated with this goal?");

                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, expectedPoints);
                    goals.Add(eternalGoal);
                }
                if (goalType == "3")
                {
                    string goalName = menu.GetUserResponse("What is the name of your goal?");
                    string goalDescription = menu.GetUserResponse("What is a short description of it?");
                    string expectedPoints = menu.GetUserResponse("What is the amount of points associated with this goal?");
                    string accomplishmentNumber = menu.GetUserResponse("How many times does this goal need to be accomplished for a bonus?");
                    string bonusPoints = menu.GetUserResponse("What is the bonus for accomplishing it that many times?");
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, expectedPoints, accomplishmentNumber, bonusPoints);
                    goals.Add(checklistGoal);
                } 
                break;

                case "2":
                Console.WriteLine("The goals are:");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {goals[i].GetGoalInfo()}");
                }
                break;

                case "3":
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {goals[i].GetGoalName()}");
                }
                string goalNumber = menu.GetUserResponse("Which goal did you accomplish?");
                goals[int.Parse(goalNumber)-1].RecordEvent();
                points = points + goals[int.Parse(goalNumber)-1].GetPoints();
                Console.WriteLine($"You now have {points} points.");
                break;

                case "6":
                quit = true;
				break;

				default:
				Console.WriteLine("That is not a valid response");
				Console.WriteLine("Hit enter to try again");
				string Input = Console.ReadLine();
				break;
            }
        }
    }
}
    


    /*AllGoals allGoals = new AllGoals();
    // Variables
    int menuSelection = 0;
    // Opening Message
    Console.Clear();
    Console.WriteLine("Welcome to the Goal Getter App!");
    Console.WriteLine();
    Thread.Sleep(2000);
    // Menu Loop
    while (menuSelection != 6)
    {
        Menu menu = new Menu();
        allGoals.DisplayPoints(allGoals.getTotalPoints());
        allGoals.DisplayLevel(allGoals.GetLevel());
        Console.WriteLine();
        menu.DisplayMainMenu();
        menuSelection = menu.DisplayGetMainMenu();
        Console.Clear();
        if (menuSelection == 1)
        {
            menu.DisplayNewGoalMenu();
            int newGoalSelection = menu.DisplayGetNewGoalMenu();
            Console.Clear();
            Goal goal = null;
            if (newGoalSelection == 1)
            {
            goal = new SimpleGoal();
            goal.DisplayGoalName();
            goal.DisplayGoalDescription();
            goal.DisplayGoalPoints();
            }
            else if (newGoalSelection == 2)
            {
            goal = new EternalGoal();
            goal.DisplayGoalName();
            goal.DisplayGoalDescription();
            goal.DisplayGoalPoints();
            }
            else
            {
            goal = new CheckListGoal();
            goal.DisplayGoalName();
            goal.DisplayGoalDescription();
            goal.DisplayGoalPoints();
            }
            // Add goal to All Goals
            if (goal != null)
            {
            allGoals.addGoal(goal);
            }
        }
        else if (menuSelection == 2)
        {
            allGoals.DisplayGoals();
        }
        else if (menuSelection == 3)
        {
            allGoals.SaveGoals();
        }
        else if (menuSelection == 4)
        {
            allGoals.LoadGoals();
        }
        else if (menuSelection == 5)
        {
            allGoals.DisplayGoalRecordEvent();
        }
        else if (menuSelection == 6)
        {
            Console.Write("Do you want to save before you quit (y/n)? ");
            string userInput = Console.ReadLine();
            if (userInput == "y" || userInput == "yes")
            {
                allGoals.SaveGoals();
            }
            return;
        }
    }*/