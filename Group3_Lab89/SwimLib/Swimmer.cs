namespace SwimLib;

public class Swimmer
{
    DateTime today = DateTime.Now;
    public byte Age 
    {
        get {return (byte)(today.Year - BDay.Year - (today < BDay.AddYears(today.Year - BDay.Year) ? 1 : 0)); } 
    }
    public DateTime BDay { get; }
    public string Club { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public Sex Sex { get; }
    public Swimmer(int id, DateTime bDay, string club, Sex sex)
    {
        this.Id = id;
        this.BDay = bDay;
        this.Club = club;
        this.Sex = sex;
    }
    public override string ToString()
    {
        return $"{Id,-5} \t {Name,-20} \t {Sex,-5}\t {Age,-5} \t {Club,-20}";
    }
}