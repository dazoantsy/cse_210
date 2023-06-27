using System.IO;
using System.Collections.Generic;

public class SaveLoadGoals
{
    private List<string[]> _goals;
    string[] lines;
    
    public SaveLoadGoals(List<string[]> goals)
    {
        _goals = goals;
    }

    public void CreateFile()
    {
        Console.Write("What is the file name for the Goal file? ");
        string _userFileName = Console.ReadLine();
        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\nYour file has been created and saved as {_userFileName} !\n");
            SaveFile(_userFileName);
        }
        else
        {
            Console.Write($"\nA file named {_userFileName} already exits.\n");
            Console.Write("Your journal entries have been added to it.\n");
            AddFile(_userFileName);
        }
    }

    public void SaveFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (string[] line in _goals)
            {
            outputFile.WriteLine((String.Join(", ", line)));
            }
        }
    }

    public void AddFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append:true))
        {
            foreach (string[] line in _goals)
            {
            outputFile.WriteLine((String.Join(", ", line)));
            }
        }
    }

    public string[] LoadFile()
    {
        Console.Write("What is your file name? ");
        string _userFileName = Console.ReadLine();
        if (File.Exists(_userFileName))
        {
            lines = File.ReadAllLines(_userFileName);//.Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        }
        return lines;
    }
}