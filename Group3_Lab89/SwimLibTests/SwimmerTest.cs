using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SwimLib;
namespace SwimLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Swimmer_Constructor_WithoutNameAdded()
        {
            DateTime bDay = DateTime.Now.AddYears(-12);
            string club = "Lion Cubs";
            int id = 25;
            Sex sex = Male;
            Swimmer swimTest = new Swimmer(id, bDay, club, sex);

            Assert.AreEqual(bDay, swimTest.bDay, "Birthday was not set correctly");
            Assert.AreEqual(club, swimTest.club, "Club was not set correctly");
            Assert.AreEqual(id, swimTest.id, "Id was not set correctly");
            Assert.AreEqual(sex, swimTest.sex, "Sex was not set correctly");
            Assert.AreEqual("", swimTest.name, "Name was not set correctly");
        }
    }
}
}
