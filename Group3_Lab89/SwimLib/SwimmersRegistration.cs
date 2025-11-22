using System.Globalization;

namespace SwimLib;

public static class SwimmersRegistration
{
    private static Meet meet;
    private const string DefaultRegistrationFolder = "registrationData/";
    private static byte ageToAgeGroup(byte age)
    {
        if (age <= 10)
        {
            return 10;
        }
        else if (age <= 12)
        {
            return 11;
        }
        else if (age <= 14)
        {
            return 13;
        }
        else
        {
            return 15;
        }
    }
    public static void RegisterSwimmers(Meet value)
    {
        meet = value;
        string error = "";
        foreach (var path in Directory.GetFiles(DefaultRegistrationFolder, "*.txt"))
        {
            try
            {
                ProcessClubRegistrationFile(path);
            }
            catch (RegistrationFileException ex)
            {
                error = $"{error} {ex.Message}";
            }

        }
        if (error.Length > 0)
        {
            throw new Exception(error);
        }


    }
    private static void ProcessClubRegistrationFile(string path)
    {
        FileStream fileIn = new FileStream(path, FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(fileIn);
        string line;
        string club = Path.GetFileNameWithoutExtension(path);
        string error = "";
        while ((line = reader.ReadLine()) != null)
        {
            try
            {
                ProcessSwimmerRecord(line, club);
            }
            catch (Exception ex)
            {
                error = $"{error} {ex.Message}";
            }
        }
        if (error.Length > 0)
        {
            throw new RegistrationFileException(error);
        }
        fileIn.Close();
        reader.Close();
    }
    private static void ProcessSwimmerRecord(string swimmerRecord, string club)
    {
        string[] details = swimmerRecord.Split(',');
        string error = "";
        try
        {
            Swimmer swimmer = new Swimmer(int.Parse(details[0]), DateTime.Parse(details[2]), club, (Sex)Enum.Parse(typeof(Sex), details[3])) { Name = details[1] };
            byte age = swimmer.Age;
            byte ageGroup = ageToAgeGroup(age);
            SwimEvent e;
            SwimEntry entry;
            int counter = 4;

            while (counter < details.Length)
            {
                e = meet.GetEvent((Stroke)Enum.Parse(typeof(Stroke), details[counter]), int.Parse(details[counter + 1]), (Sex)Enum.Parse(typeof(Sex), details[3]), ageGroup);
                if (e != null)
                {
                    entry = new SwimEntry(swimmer, e, TimeSpan.ParseExact(details[counter + 2], @"mm\:ss\.ff", CultureInfo.InvariantCulture));
                    e.AddSwimEntry(entry);
                }
                else
                {
                    error = $"{error} Swim Event does not exists for record {swimmerRecord} in {club} club\n";
                }
                counter += 3;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Invalid swimmer record: {swimmerRecord}");
        }
        if (error != "")
        {
            throw new Exception(error);
        }
    }

}