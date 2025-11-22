namespace SwimLib;

public class RandomSeedingService(Meet meet) : SeedingService(meet)
{
    Random random = new Random();

    public override int SeedEvent(SwimEvent swimEvent)
    {
        List<SwimEntry> swimEntries = swimEvent.SwimEntries.OrderBy(e => random.Next()).ToList();
        byte numberOfHeats = (byte)Math.Ceiling((double)swimEntries.Count / (double)poolLane);

        int swimEntriesCount = swimEntries.Count;
        for (byte i = 0; i < numberOfHeats; i++)
        {
            int start = i * poolLane;
            int ending = Math.Min(start + poolLane, swimEntriesCount);
            byte middle = middleLane;
            bool isRight = true; // +1
            // bool isLeft = false; // -1
            bool isFirst = true; //first iteration
            byte count = 1;
            int lastIteration = poolLane * (i + 1);
            for (int j = start; j < ending; j++)
            {
                SwimEntry e = swimEntries[j];
                e.HeatNumber = (byte)(i + 1);
                if (isFirst)
                {
                    e.LaneNumber = middle;
                    isFirst = false;
                }
                else if (isRight) //2nd, 4th ... iteration
                {
                    e.LaneNumber = (byte)(middle + count);
                    isRight = false;
                }
                else
                {
                    e.LaneNumber = (byte)(middle - count);
                    isRight = true;
                    count += 1;
                }

            }
        }
        return numberOfHeats;
    }
}