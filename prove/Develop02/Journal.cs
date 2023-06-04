using System;
using System.IO;
public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    //public string _userFileName;
    public Journal()
    {
    }

    public void Display()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }

    public void SaveFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry entry in _journal)
            {
            outputFile.WriteLine($"{entry._time}; {entry._prompt}; {entry._entry}");
            }
        }
    }

    public void AddFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append:true))
        {
            foreach (Entry entry in _journal)
            {
            outputFile.WriteLine($"{entry._time}; {entry._prompt}; {entry._entry}");
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("What is your file name? ");
        string _userFileName = Console.ReadLine();
        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                Entry entry = new Entry();
                entry._time = entries[0];
                entry._prompt = entries[1];
                entry._entry = entries[2];
                _journal.Add(entry);
            }
        }
    }

    public void CreateFile()
    {
        Console.Write("Enter file name? ");
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
}
