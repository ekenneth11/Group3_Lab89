using SwimLib;
namespace SwimLibTests
{
    [TestClass]
    public sealed class SwimmerTest
    {
        [TestMethod] 
        public void Swimmer_Constructor_WithoutNameAdded() 
        { 
            DateTime bDay = DateTime.Now.AddYears(-12); 
            string club = "Lion Cubs"; 
            int id = 25; 
            Sex sex = Sex.Male; 
            Swimmer swimTest = new Swimmer(id, bDay, club, sex); 
            
            Assert.AreEqual(bDay, swimTest.BDay, "Birthday was not set correctly"); 
            Assert.AreEqual(club, swimTest.Club, "Club was not set correctly"); 
            Assert.AreEqual(id, swimTest.Id, "Id was not set correctly"); 
            Assert.AreEqual(sex, swimTest.Sex, "Sex was not set correctly"); 
            Assert.IsNull(swimTest.Name, "Name was not set correctly"); 
        }

        [TestMethod]
        public void Swimmer_Age_LeapYearBirthday()
        {
            DateTime testBday = new DateTime(2000, 2, 29);
            DateTime today = DateTime.Now;
            DateTime bday = new DateTime(2000, 2, 28);
            byte bdayCheck = (byte)(today.Year - bday.Year - (today < bday.AddYears(today.Year - bday.Year) ? 1 : 0));

            Swimmer swimmerTest = new Swimmer(25, testBday, "Lion Cubs", Sex.Male);

            Assert.AreEqual(bdayCheck, swimmerTest.Age, "Something wrong with your birthday");
        }
        [TestMethod]
        public void Swimmer_Constructor_addNameAfter()
        {
            DateTime bDay = DateTime.Now.AddYears(-12);
            string club = "Lion Cubs"; 
            int id = 25;
            Sex sex = Sex.Male;
            Swimmer swimTest = new Swimmer(id, bDay, club, sex);

            Assert.AreEqual(bDay, swimTest.BDay, "Birthday was not set correctly");
            Assert.AreEqual(club, swimTest.Club, "Club was not set correctly");
            Assert.AreEqual(id, swimTest.Id, "Id was not set correctly");
            Assert.AreEqual(sex, swimTest.Sex, "Sex was not set correctly");
            Assert.IsNull(swimTest.Name, "Name was not set correctly");
            swimTest.Name = "Dan";
            Assert.IsNotNull(swimTest.Name, "Name was not set correctly");
        }
        [TestMethod]
        public void Swimmer_Properties_SetAndGet()
        {
            DateTime bDay = DateTime.Now.AddYears(-12);
            string club = "Lion Cubs"; 
            int id = 25;
            Sex sex = Sex.Male;
            string name = "Dan";
            Swimmer swimTest = new Swimmer(id, bDay, club, sex) {Name = name};
            Assert.AreEqual(bDay, swimTest.BDay, "Birthday was not set correctly");
            Assert.AreEqual(club, swimTest.Club, "Club was not set correctly");
            Assert.AreEqual(id, swimTest.Id, "Id was not set correctly");
            Assert.AreEqual(sex, swimTest.Sex, "Sex was not set correctly");
            Assert.AreEqual(name, swimTest.Name, "Name was not set correctly");

            //changing the properties
            swimTest.Club = "Flying Penguins";
            swimTest.Id = 26;
            swimTest.Name = "Kris";
            Assert.AreNotEqual(club, swimTest.Club, "Club was not set correctly");
            Assert.AreNotEqual(id, swimTest.Id, "Id was not set correctly");
            Assert.AreNotEqual(name, swimTest.Name, "Name was not set correctly");
        }
    }
}
