using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new Running("07/05/2023", 8.2, 835));
        activities.Add(new Cycling("07/12/2023", 10, 21));
        activities.Add(new Swimming("07/19/2023", 12, 127));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY {index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}