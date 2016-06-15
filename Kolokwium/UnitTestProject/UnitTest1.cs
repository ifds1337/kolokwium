using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LiczTripletTest()
        {
            //Program target = new Program();
            int numberA = 3;
            int numberB = 5;
            int expected = 8;
            int actual;
            actual = Program.Add(numberA, numberB);
            Assert.AreEqual(expected, actual);


            // //int [] lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> sublista = new List<int> { 1, 2, 3, 4, 5 };
           // Assert.AreEqual<List<int>>(Program.SubList(lista, 0, 4), sublista);
        }
    }
}
