using System;
public class Entry
{
    public string _time = "";
    public string _prompt = "";
    public string _entry = "";

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_time}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}\n");
    }
}