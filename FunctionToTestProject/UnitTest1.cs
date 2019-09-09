using FunctionToTestConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FunctionToTestProject {
    [TestClass]
    public class UnitTest1 {

        ForcastingFunction ff = null;

        [TestInitialize] //will run just once when class begins
        public void TestInit() {
            ff = new ForcastingFunction();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestParmsOutsideDomain() {
            ff.Multiplier = 0;
            Assert.AreEqual(0, ff.Forecast(100,100));
        }


        [TestMethod]
        public void TestValidInputsWithMultiplierZero() {
            //Multiplier is zero
            ff.Multiplier = 0;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(1, 1), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");

            //test multiplier of 2, x of 2, y of 2, result is 24
            //var ff = new ForcastingFunction();  //we no longer need this we have it defined in the begining and have set the TestInitializer 
            //ff.Multiplier = 2;
            //var result = ff.Forecast(2, 2);
            //Assert.AreEqual(24, result);
            //ff.Multiplier = 3;
            //Assert.AreEqual(36, ff.Forecast(2, 2), "Result should be 36");
        }

        [TestMethod]
        public void TestValidInputsWithMultiplierOne() {
            ff.Multiplier = 1;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(2, ff.Forecast(1, 1), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");

        }

        [TestMethod]
        public void TestValidInputsWithMultiplierFive() {
            ff.Multiplier = 5;
            Assert.AreEqual(0, ff.Forecast(0, 0), "Result should be zero");
            Assert.AreEqual(10, ff.Forecast(1, 1), "Result should be zero");
            Assert.AreEqual(0, ff.Forecast(-1, -1), "Result should be zero");
            Assert.AreEqual(60, ff.Forecast(2, 2), "Result should be zero");
            Assert.AreEqual(-20, ff.Forecast(-2, -2), "Result should be zero");
            Assert.IsTrue(ff.Multiplier % 5 == 0);
  
        }

    }
}
