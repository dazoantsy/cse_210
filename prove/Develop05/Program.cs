using System;
class Program
{
    static void Main(string[] args)
    {
        List<string[]> goal = new List<string[]>();
        List<string[]> recuperationGoal = new List<string[]>();
        int points = 0;
        string[] point = {$"{points}"};
        goal.Add(point);
        bool quit = false;
		while (quit == false)
		{
            Menu menu = new Menu();
            SaveLoadGoals saveload = new SaveLoadGoals(goal);
            //Console.Clear();
            Console.WriteLine();
            Console.WriteLine(menu.DisplayPoints(int.Parse(goal[0][0])));
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

                    string[] goalDetails = {"Simple Goal", goalName, goalDescription, expectedPoints, "0"};
                    goal.Add(goalDetails);
                }
                if (goalType == "2")
                {
                    string goalName = menu.GetUserResponse("What is the name of your goal?");
                    string goalDescription = menu.GetUserResponse("What is a short description of it?");
                    string expectedPoints = menu.GetUserResponse("What is the amount of points associated with this goal?");
                    
                    string[] goalDetails = {"Eternal Goal", goalName, goalDescription, expectedPoints};
                    goal.Add(goalDetails);
                }
                if (goalType == "3")
                {
                    string goalName = menu.GetUserResponse("What is the name of your goal?");
                    string goalDescription = menu.GetUserResponse("What is a short description of it?");
                    string expectedPoints = menu.GetUserResponse("What is the amount of points associated with this goal?");
                    string accomplishmentNumber = menu.GetUserResponse("How many times does this goal need to be accomplished for a bonus?");
                    string bonusPoints = menu.GetUserResponse("What is the bonus for accomplishing it that many times?");
                    
                    string[] goalDetails = {"Checklist Goal", goalName, goalDescription, expectedPoints, accomplishmentNumber, bonusPoints, "0"};
                    goal.Add(goalDetails);
                }
                Console.WriteLine(); 
                break;

                case "2":
                Console.WriteLine("The goals are:");
                int i = 1;
                foreach (string[] line in goal)
                {
                    if (line[0] == "Simple Goal")
                    {
                        SimpleGoal simpleGoal1 = new SimpleGoal(line[1], line[2], line[3], int.Parse(line[4]));
                        Console.WriteLine($"{i}. {simpleGoal1.GetGoalStatus()} {simpleGoal1.GetGoalInfo()}");
                        i++;
                    }
                    if (line[0] == "Eternal Goal")
                    {
                        EternalGoal eternalGoal1 = new EternalGoal(line[1], line[2], line[3]);
                        Console.WriteLine($"{i}. {eternalGoal1.GetGoalStatus()} {eternalGoal1.GetGoalInfo()}");
                        i++;
                    }
                    if (line[0] == "Checklist Goal")
                    {
                        ChecklistGoal checklistGoal1 = new ChecklistGoal(line[1], line[2], line[3], line[4], line[5], int.Parse(line[6]));
                        Console.WriteLine($"{i}. {checklistGoal1.GetGoalStatus()} {checklistGoal1.GetGoalInfo()}");
                        i++;
                    }
                }
                break;

                case "3":
                Console.Clear();
                saveload.CreateFile();
                break;

                case "4":
                Console.Clear();
                string[] exportedGoals = saveload.LoadFile();
                foreach (string goalExported in exportedGoals)
                {
                    string[] eachGoalDetails = goalExported.Split(", ");
                    recuperationGoal.Add(eachGoalDetails);
                }
                goal = recuperationGoal;
                break;

                case "5":
                Console.Clear();
                Console.WriteLine("The goals are:");
                int n = 1;
                foreach (string[] line in goal)
                {
                    if (line[0] == "Simple Goal")
                    {
                        SimpleGoal simpleGoal2 = new SimpleGoal(line[1], line[2], line[3], int.Parse(line[4]));
                        Console.WriteLine($"{n}. {simpleGoal2.GetGoalName()}");
                        n++;
                    }
                    if (line[0] == "Eternal Goal")
                    {
                        EternalGoal eternalGoal2 = new EternalGoal(line[1], line[2], line[3]);
                        Console.WriteLine($"{n}. {eternalGoal2.GetGoalName()}");
                        n++;
                    }
                    if (line[0] == "Checklist Goal")
                    {
                        ChecklistGoal checklistGoal2 = new ChecklistGoal(line[1], line[2], line[3], line[4], line[5], int.Parse(line[6]));
                        Console.WriteLine($"{n}. {checklistGoal2.GetGoalName()}");
                        n++;
                    }
                }
                points = int.Parse(goal[0][0]);
                string goalNumber = menu.GetUserResponse("Which goal did you accomplish?");
                string[] chosenGoal = goal[int.Parse(goalNumber)];
                if (chosenGoal[0] == "Simple Goal")
                {
                    int accomplishment1 = int.Parse(chosenGoal[4])+1;
                    chosenGoal[4] = accomplishment1.ToString();
                    SimpleGoal simpleGoal3 = new SimpleGoal(chosenGoal[1], chosenGoal[2], chosenGoal[3], int.Parse(chosenGoal[4]));
                    points = points + simpleGoal3.GetPoints();
                    simpleGoal3.RecordEvent(points);
                }
                if (chosenGoal[0] == "Eternal Goal")
                {
                    EternalGoal eternalGoal3 = new EternalGoal(chosenGoal[1], chosenGoal[2], chosenGoal[3]);
                    points = points + eternalGoal3.GetPoints();
                    eternalGoal3.RecordEvent(points);
                }
                if (chosenGoal[0] == "Checklist Goal")
                {
                    int accomplishment2 = int.Parse(chosenGoal[6])+1;
                    chosenGoal[6] = accomplishment2.ToString();
                    ChecklistGoal checklistGoal3 = new ChecklistGoal(chosenGoal[1], chosenGoal[2], chosenGoal[3], chosenGoal[4], chosenGoal[5], int.Parse(chosenGoal[6]));
                    points = points + checklistGoal3.GetPoints();
                    checklistGoal3.RecordEvent(points);
                }
                goal[0][0] = points.ToString();
                Console.WriteLine();
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