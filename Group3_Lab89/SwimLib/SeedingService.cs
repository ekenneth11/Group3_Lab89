namespace SwimLib;

public abstract class SeedingService
{
    protected byte middleLane;
    protected byte poolLane;
    public SeedingService(Meet meet)
    {
        middleLane = (byte)Math.Ceiling((double)meet.PoolLanes / 2);
        poolLane = meet.PoolLanes;
    }
    public abstract int SeedEvent(SwimEvent swimEvent);
}