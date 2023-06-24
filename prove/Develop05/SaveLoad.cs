using System.IO;
using System.Collections.Generic;

public class SaveLoad
{
    private List<string> _details, _loadedDetails;
    //private string _type, _name, _description, _points, _status, _bonusRequirement, _bonusPoints;

    public SaveLoad(List<string> details)
    {
        _details = details;
    }

    public void CreateFile(string fileToCreate)
    {
        Console.Write($"What is the file name for the ${fileToCreate} file? ");
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
            foreach (string line in _details)
            {
            outputFile.WriteLine((String.Join(", ", _details)));
            }
        }
    }

    public void AddFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append:true))
        {
            foreach (string line in _details)
            {
            outputFile.WriteLine((String.Join(", ", _details)));
            }
        }
    }

    public List<string> LoadFile()
    {
        Console.Write("What is your file name? ");
        string _userFileName = Console.ReadLine();
        if (File.Exists(_userFileName))
        {
            _loadedDetails = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        }
        return _loadedDetails;
    }
}