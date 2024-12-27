using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MerzhinskiyOO.Sprint0.Task2.V1.Lib;

namespace Tyuiu.MerzhinskiyOO.Sprint0.Task2.V1.Test
{
    [TestClass]
    public class DataSeriveTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Олег";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Олег", res);
        }
    }
}
