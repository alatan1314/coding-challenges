using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OES.RobotWars;

namespace UnitTestRobotWars
{
    [TestClass]
    public class ShipTest
    {
        [TestMethod]
        public void GetNewDirection()
        {
            Coordinates areaSize = new Coordinates(5,5);

            Ships myShip = new Ships(3,3,"N");
            myShip.Instruction("L", areaSize);
            Assert.AreEqual("W", myShip.Direction);
            myShip.Instruction("L", areaSize);
            myShip.Instruction("L", areaSize);
            Assert.AreEqual("E", myShip.Direction);
            myShip.Instruction("R", areaSize);
            myShip.Instruction("R", areaSize);
            myShip.Instruction("R", areaSize);
            Assert.AreEqual("N", myShip.Direction);
        }

        [TestMethod]
        public void GetNewLocation()
        {
            Coordinates areaSize = new Coordinates(5, 5);
            Ships myShip = new Ships(3, 3, "N");
            myShip.Instruction("R", areaSize);
            myShip.Instruction("M", areaSize);
            Assert.AreEqual(4, myShip.X);
        }

        [TestMethod]
        public void CheckInvalidLocation()
        {
            Coordinates areaSize = new Coordinates(5,5);
            Ships myShip = new Ships(3, 3, "N");
            myShip.Instruction("M", areaSize);
            myShip.Instruction("M", areaSize);
            bool result = myShip.Instruction("M", areaSize);
            Assert.AreEqual(false, result);
        }

    }
}