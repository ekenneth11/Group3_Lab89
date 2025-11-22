using System.Reflection;
using System.Text.Json.Serialization;

namespace SwimLib;

public class SwimEvent
{
    [JsonInclude]
    private ushort eventNumber;
    private static ushort eventsNo = 0;
    int numberOfHeats;
    private List<SwimEntry> swimEntries;



    public byte AgeGroup { get; set; }
    public int Distance { get; set; }
    public Gender Gender { get; set; }
    [JsonIgnore]
    public SeedingService SeedingService { get; set; }
    public Stroke Stroke { get; set; }
    [JsonIgnore]
    public List<SwimEntry> SwimEntries
    {
        get { return swimEntries; }
    }



    public void AddSwimEntry(SwimEntry swimEntry)
    {
        this.swimEntries.Add(swimEntry);
        swimEntry.Event = this;

    }
    public void GenerateEventHeatSheet(StreamWriter stream)
    {
        try
        {
            SeedEvent();
        }
        catch
        {
            throw;
        }
        List<SwimEntry> entriesSorted = swimEntries.OrderBy(e => e.HeatNumber).ThenBy(e => e.LaneNumber).ToList();
        stream.WriteLine($"Event #{eventNumber} {Gender} {AgeGroup} {Distance}m {Stroke}");
        stream.WriteLine("Lane  Name                Age Club      Seed Time");
        stream.WriteLine("-------------------------------------------------");
        byte currentHeat = 0;
        foreach (SwimEntry e in entriesSorted)
        {
            if (e.HeatNumber != currentHeat)
            {
                currentHeat = e.HeatNumber;
                stream.WriteLine("");
                stream.WriteLine($"Heat#{currentHeat} of {numberOfHeats}");
            }
            stream.WriteLine($"#{e.LaneNumber,-5} {e.Swimmer.Name,-20}{e.Swimmer.Age,-5}{e.Swimmer.Club,-15}{e.SeedTime.ToString(@"mm\:ss\.ff")}");
        }
        stream.WriteLine("");
    }
    public void SeedEvent()
    {
        if (SeedingService == null)
        {
            this.numberOfHeats = 0;
            throw new Exception($"Seeding service is not set for the event {this.Gender} {this.Distance}m {this.Stroke} Age group: {this.AgeGroup}\n");
        }
        this.numberOfHeats = SeedingService.SeedEvent(this);
    }
    public static void SetEventsNoAfterLoad(ushort value)
    {
        eventsNo = value;
    }
    public SwimEvent()
    {
        this.swimEntries = new List<SwimEntry>();
    }
    public SwimEvent(Stroke stroke, int distance, Gender gender, byte age) : this()
    {
        this.Stroke = stroke;
        this.Distance = distance;
        this.Gender = gender;
        this.AgeGroup = age;
        eventsNo += 1;
        this.eventNumber = eventsNo;
    }


    public override string ToString()
    {
        swimEntries.Sort((p1, p2) => p1.SeedTime.CompareTo(p2.SeedTime));
        string header = "#  ID      Name              Sex  Age     Club                Seed Time";
        string details = "";
        if (swimEntries.Count == 0)
        {
            details = "\t [No Entries]";
        }
        else
        {
            int counter = 1;
            foreach (SwimEntry i in swimEntries)
            {
                details += counter + i.ToString() + "\n";
                counter += 1;
            }
        }

        string result = $"Event #{eventNumber} {Distance}m {Stroke} ({Gender}), Age group: {AgeGroup}\n{header}\n{details}";

        return result;
    }
}