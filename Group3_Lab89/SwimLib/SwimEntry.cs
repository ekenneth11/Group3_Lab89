namespace SwimLib;

public class SwimEntry
{
    public SwimEvent Event { get; set; }
    public byte HeatNumber { get; set; }
    public byte LaneNumber { get; set; }
    public TimeSpan Result { get; set; }
    public TimeSpan SeedTime { get; set; }
    public Swimmer Swimmer { get; set; }

    public SwimEntry(Swimmer swimmer, SwimEvent swimEvent, TimeSpan seedtime)
    {
        this.Swimmer = swimmer;
        this.Event = swimEvent;
        this.SeedTime = seedtime;
    }
    public override string ToString()
    {
        return $"  {Swimmer.Id}    {Swimmer.Name,-20} {Swimmer.Sex,-5} {Swimmer.Age,-5} {Swimmer.Club,-20} {SeedTime.ToString(@"mm\:ss\.ff")}  ";
    }

}