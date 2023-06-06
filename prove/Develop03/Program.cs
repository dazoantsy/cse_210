using System;

class Program
{
	static void Main(string[] args)
	{
		Reference scriptureReference = new Reference("Proverbs", "3", "5", "6");
		string scriptureVerse = "Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding. In all thy ways acknowledge him, and he shall direct thy paths.";
		ListConversion listConversion = new ListConversion(scriptureVerse);
		Scripture scripture = new Scripture(listConversion.convertToList());
		Word words = new Word(listConversion.convertToList());
        
		Console.WriteLine(string.Format("{0}\n{1}", scriptureReference.toString(), scriptureVerse));
		Console.WriteLine("\nPress Enter to continue or type 'quit' to exit");

		string userInput = Console.ReadLine();

		while (userInput != "quit" && words.hasShownWords() == true)
		{
			scripture.removeWordsFromList();
			Console.Clear();
			Console.WriteLine(string.Format("{0}\n{1}", scriptureReference.toString(), scripture.toString()));
			Console.WriteLine();
			userInput = Console.ReadLine();
		}
		
	}
}