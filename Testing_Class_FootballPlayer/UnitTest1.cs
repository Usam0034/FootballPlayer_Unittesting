using System;
using FootballPlayer_Unittesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing_Class_FootballPlayer
{
    [TestClass]
    public class UnitTest1
    {
        
        
            [TestMethod]
            public void NameTest()
            {
                FootballPlayer footballPlayer = new FootballPlayer("Hassan");
                Assert.AreEqual("Hassan", footballPlayer.name);

                try
                {
                    footballPlayer.name = "BO";
                    Assert.Fail();
                }
                catch (ArgumentException e)
                {

                }
            }

            [TestMethod]

            public void PriceTest()
            {
                FootballPlayer footballPlayer = new FootballPlayer("Jens");
                footballPlayer.price = 334.000;
                Assert.AreEqual(334.000, footballPlayer.price);

                Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.price = -1);
            }

            [TestMethod]

            public void ShirtTest()
            {
                FootballPlayer footballPlayer = new FootballPlayer("Hans");
                footballPlayer.shirtNumber = 50;
                Assert.AreEqual(50, footballPlayer.shirtNumber);

                Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayer.shirtNumber = 200);

            }
    }  
}
