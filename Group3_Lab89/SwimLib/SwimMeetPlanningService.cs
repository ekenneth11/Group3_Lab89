using System.Reflection;
using System.Text.Json;

namespace SwimLib;

public class SwimMeetPlanningService
{
    private const string DefaultEventFile = "data/events.json";
    public Meet Meet { get; set; }

    public SwimMeetPlanningService(int PoolLength, byte PoolLanes)
    {
        Meet = Meet.CreateMeet(PoolLength, PoolLanes);
        if (File.Exists(DefaultEventFile))
        {
            ImportEvents(DefaultEventFile);
        }

    }
    public void ImportEvents(string path)
    {
        FileStream fileIn = new FileStream(path, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fileIn);
        string json = reader.ReadToEnd();
        List<SwimEvent> events = JsonSerializer.Deserialize<List<SwimEvent>>(json);
        foreach (SwimEvent e in events)
        {
            Sex sex = e.Gender == Gender.Male ? Sex.Male : e.Gender == Gender.Female ? Sex.Female : Sex.Male;
            if (Meet.GetEvent(e.Stroke, e.Distance, sex, e.AgeGroup) == null)
            {
                Meet.AddEvent(e);

            }
            SwimEvent.SetEventsNoAfterLoad((ushort)Meet.Events.Count);
        }

        fileIn.Close();
        reader.Close();

    }
    public void ExportEvents(string path)
    {
        FileStream fileOut = new FileStream(path, FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(fileOut);
        List<SwimEvent> events = Meet.Events;
        string jsonString = JsonSerializer.Serialize(events);
        writer.Write(jsonString);
        writer.Close();
        fileOut.Close();

    }
    public void RegisterSwimmers(string path = null)
    {
        SwimmersRegistration.RegisterSwimmers(Meet);
    }
}