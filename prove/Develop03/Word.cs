using System;

public class Word
{
	//private string _word;
	private List<string> _textList;
	
	public Word(List<string> textList)
	{
		_textList = textList;
	}
	
	public bool hasShownWords()
	{
		bool retValue = false;
		foreach (string word in _textList)
		{
			if (word.Contains('_') == false)
			{
				retValue = true;
				break;
			}
		}
	return retValue;
	}
	/*public string textInList()
	{
		return string .Join(' ', _textList);
	}*/
}