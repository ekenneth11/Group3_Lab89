using SwimLib;

namespace Group3_Lab89
{
    class Program
    {
        static void Main(string[] args)
        {
            SwimMeetPlanningService swimMeetPlaningService = new SwimMeetPlanningService(25, 8);
            Meet meet = swimMeetPlaningService.Meet;
            Console.WriteLine(meet);
            SwimMeetPlanningService swimMeetPlaningService2 = new SwimMeetPlanningService(25, 6);
            SwimEvent event10UX = new SwimEvent(Stroke.Breaststroke, 100, Gender.Mixed, 10); // 10 and under mixed
            SwimEvent event11X = new SwimEvent(Stroke.Breaststroke, 100, Gender.Mixed, 11); // 11 mixed
            SwimEvent event13X = new SwimEvent(Stroke.Breaststroke, 100, Gender.Mixed, 13); // 13 mixed
            meet.AddEvent(event10UX);
            meet.AddEvent(event11X);
            meet.AddEvent(event13X);
            Console.WriteLine(meet);
            Console.WriteLine("******Register Swimmers*******");
            try
            {
                swimMeetPlaningService2.RegisterSwimmers();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(meet);
            swimMeetPlaningService2.ExportEvents(@"events.json");
            Console.WriteLine("******Generate Heat sheet ProblemFile.txt*******");
            try
            {
                meet.GenerateHeatSheet("ProblemFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n ProblemFile.txt is not valid");
            }
            Console.WriteLine("******Generate Heat sheet HeatSheetTimedFinals.txt*******");
            meet.SeedingService = new TimeFinalSeedingService(meet);
            meet.GenerateHeatSheet("HeatSheetTimedFinals.txt");
            Console.WriteLine("******Generate Heat sheet HeatSheetRandom?.txt*******");
            meet.SeedingService = new RandomSeedingService(meet);
            meet.GenerateHeatSheet("HeatSheetRandom1.txt");
            meet.GenerateHeatSheet("HeatSheetRandom2.txt");
            }
        }
    }
