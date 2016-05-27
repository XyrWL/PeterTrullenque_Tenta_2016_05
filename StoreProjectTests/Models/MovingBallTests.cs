using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreProject.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Models.Tests
{
    [TestClass]
    public class MovingBallTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void GetCurrentSpeed_ZeroTime()
        {
            var ball = new MovingBall();
            ball.GetCurrentSpeed(distance: 5, time: 0);
        }

        [TestMethod]
        public void GetCurrentSpeed_ZeroDistance()
        {
            var ball = new MovingBall();
            var actual = ball.GetCurrentSpeed(distance: 0, time: 5);
            double expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCurrentSpeed_CorrectCalculation()
        {
            var ball = new MovingBall();
            var actual = ball.GetCurrentSpeed(distance: 10.5, time: 2);
            double expected = 5.25;
            Assert.AreEqual(expected, actual);
        }
    }
}