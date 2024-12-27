using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MerzhinskiyOO.Sprint0.Task3.V1.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint0.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
