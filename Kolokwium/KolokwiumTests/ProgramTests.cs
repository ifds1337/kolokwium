using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolokwium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void LiczTripletTest()
        {
            int[] A = new int[] { -3, 1, 2, -2, 5, 6 };
            int P = 1, Q = 2, R = 4;

            int expected = 10;
            int actual;

            actual = Program.LiczTriplet(A, P, Q, R);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ZnajdzTriplet()
        {
            int[] A = new int[] { -3, 1, 2, -2, 5, 6 };

            int expected = 60;
            int actual;

            actual = Program.ZnajdzTriplet(A);
            Assert.AreEqual(expected, actual);
        }
    }
}