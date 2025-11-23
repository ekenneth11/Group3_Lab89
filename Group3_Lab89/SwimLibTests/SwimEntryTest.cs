using SwimLib;
namespace SwimLibTests;

[TestClass]
public class SwimEntryTest
{
    [TestMethod]
    public void SwimEntry_Constructor()
    {
        Swimmer swimTest = new Swimmer(25, DateTime.Now.AddYears(-12), "Lion Cubs", Sex.Male);
        SwimEvent swimEventTest = new SwimEvent(Stroke.Backstroke, 50, Gender.Male, 12);
        SwimEntry swimEntryTest = new SwimEntry(swimTest, swimEventTest, new TimeSpan(0, 0, 1, 5, 500));

        Assert.IsNotNull(swimEntryTest);
        Assert.AreEqual(swimTest, swimEntryTest.Swimmer);
        Assert.AreEqual(swimEventTest, swimEntryTest.Event);
    }
    [TestMethod]
    public void SwimEntry_Properties_NoValues()
    {
        Swimmer swimTest = new Swimmer(25, DateTime.Now.AddYears(-12), "Lion Cubs", Sex.Male);
        SwimEvent swimEventTest = new SwimEvent(Stroke.Backstroke, 50, Gender.Male, 12);
        SwimEntry swimEntryTest = new SwimEntry(swimTest, swimEventTest, new TimeSpan(0, 0, 1, 5, 500));

        Assert.AreEqual(TimeSpan.Zero, swimEntryTest.Result, "Result must be 00:00:00");
        Assert.AreEqual((byte)0, swimEntryTest.HeatNumber, "Heat Number must be 0");
        Assert.AreEqual((byte)0, swimEntryTest.LaneNumber, "Lane Number must be 0");
    }
}
