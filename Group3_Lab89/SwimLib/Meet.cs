namespace SwimLib;

public class Meet
{
    private static Meet meet;
    private List<SwimEvent> events;

    public byte PoolLanes { get; set; }
    public int PoolLength { get; set; }
    public List<SwimEvent> Events
    {
        get { return events; }
    }
    public SeedingService SeedingService
    {
        set
        {
            foreach (SwimEvent e in events)
            {
                e.SeedingService = value;
            }
        }
    }
    public void AddEvent(SwimEvent swimEvent)
    {
        events.Add(swimEvent);
    }
    public static Meet CreateMeet(int PoolLength, byte PoolLanes)
    {
        if (meet == null)
        {
            meet = new Meet();
        }
        meet.PoolLanes = PoolLanes;
        meet.PoolLength = PoolLength;
        return meet;
    }
    public void GenerateHeatSheet(string path)
    {
        FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter writer = new StreamWriter(fileStream);
        string error = "";
        foreach (SwimEvent e in events)
        {
            try
            {
                e.GenerateEventHeatSheet(writer);

            }
            catch (Exception ex)
            {
                error = $"{error} {ex.Message}";
            }
        }
        if (error.Length > 0)
        {
            throw new Exception(error);
        }
        writer.Close();
        fileStream.Close();

    }
    public SwimEvent GetEvent(Stroke stroke, int distance, Sex sex, byte ageGroup)
    {
        foreach (SwimEvent e in events)
        {
            if (e.Stroke == stroke && e.Distance == distance && e.AgeGroup == ageGroup)
            {
                if (e.Gender == Gender.Mixed || (e.Gender == Gender.Female && sex == Sex.Female) || (e.Gender == Gender.Male && sex == Sex.Male))
                {
                    return e;
                }
            }
        }
        return null;
    }
    private Meet()
    {
        this.events = new List<SwimEvent>();

    }
    public override string ToString()
    {
        string header = $"Meet: Pool Length = {PoolLength}, Pool Lanes = {PoolLanes} \n";
        string result = $"{header} Events: \n";
        if (events.Count == 0)
        {
            result += "\t [No Entries]";
        }
        else
        {
            foreach (SwimEvent i in events)
            {
                result += i.ToString() + "\n";
            }
        }

        return result;
    }
}