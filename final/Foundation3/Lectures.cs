public class Lectures : Event
{
    private string _speaker;
    private string _limitedCapacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, string limitedCapacity) : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _limitedCapacity =  limitedCapacity;
    }
    public override string FullDetails()
    {
        return StandardDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_limitedCapacity}\n";
    }
}