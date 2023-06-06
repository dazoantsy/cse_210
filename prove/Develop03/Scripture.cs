using System;

public class Scripture
{
	//private string _scriptureText;
	//private string _scriptureReference;
	private List<string> _textList;
	
	public Scripture(List<string> scriptureTextList)
	{
		_textList = scriptureTextList;
	}

	/*private void convertToList()
	{
		_textList = _scriptureText.Split(' ').ToList();
	}*/

	public void removeWordsFromList()
	{
		int wordsToRemove = new Random().Next(3);
		int wordsRemoved = 0;
		do
		{
			int randomIndex = new Random().Next(0, _textList.Count());
			if (_textList[randomIndex].Contains('_') == false)
			{
				_textList[randomIndex] = new string('_', _textList[randomIndex].Length);
				wordsRemoved++;
			}		
		}
		while (wordsRemoved != wordsToRemove);
	}
	
	public string toString()
	{
		return string .Join(' ', _textList);
	}

	/*public List<string> convertedList()
	{
		return _textList;
	}*/
}