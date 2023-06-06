using System;

public class Reference
{
	private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
	
	public Reference (string book, string chapter, string verse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;
	}

    public Reference (string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
	
	public string toString()
	{
		if (_endVerse == null)
        {
            string _reference = $"{_book} {_chapter}:{_verse}";
            return _reference;
        }
        else
        {
            string _reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return _reference;
        }
	}
}