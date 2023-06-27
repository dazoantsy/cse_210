using System;
public class Menu
{
    private List<string> mainMenu, GoalTypeMenu;
    private string _points = "0";
    //private int mainMenuSelection ;
    //private int newGoalSelection;
    public Menu()
    {
        mainMenu = new List<string>
        {
        "Menu Options:",
        " 1. Create New Goal",
        " 2. List Goals",
        " 3. Save Goals",
        " 4. Load Goals",
        " 5. Record Event",
        " 6. Quit"
        };
        GoalTypeMenu = new List<string>
        {
        "The types of Goals are:",
        " 1. Simple Goal",
        " 2. Eternal Goal",
        " 3. CheckList Goal"
        };
    }
    public void DisplayMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }

    public void DisplayGoalTypeMenu()
    {
        foreach (string menuItem2 in GoalTypeMenu)
        {
            Console.WriteLine(menuItem2);
        }
    }
    
    public string GetUserResponse(string question)
    {
        Console.WriteLine($"{question}");
        return Console.ReadLine();
    }

    public string DisplayPoints(int points)
    {
        _points = points.ToString();
        return $"You have {_points} points";
    }
}