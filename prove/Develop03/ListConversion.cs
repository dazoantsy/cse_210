using System;

public class ListConversion
{
    private List<string> convertedList;
    private string _text;

    public ListConversion(string text)
    {
        _text = text;
    }

    public List<string> convertToList()
    {
        convertedList = _text.Split(' ').ToList();
        return convertedList;
    }

    /*public string convertToText()
    {
        return string .Join(' ', _list);
    }*/
}