using SwimLib;
namespace SwimLibTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod] 
        public void Swimmer_Constructor_WithoutNameAdded() 
        { 
            DateTime bDay = DateTime.Now.AddYears(-12); 
            string club = "Lion Cubs"; int id = 25; 
            Sex sex = Sex.Male; 
            Swimmer swimTest = new Swimmer(id, bDay, club, sex); 
            
            Assert.AreEqual(bDay, swimTest.BDay, "Birthday was not set correctly"); 
            Assert.AreEqual(club, swimTest.Club, "Club was not set correctly"); 
            Assert.AreEqual(id, swimTest.Id, "Id was not set correctly"); 
            Assert.AreEqual(sex, swimTest.Sex, "Sex was not set correctly"); 
            Assert.IsNull(swimTest.Name, "Name was not set correctly"); 
        }
    }
}
