using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication_Demo_UnitTests.Models;

namespace WebApplication_Demo_UnitTests.Tests.Models
{
    [TestClass]
    public class UnitTestCalcul
    {
        [TestMethod]
        public void TestAdditionner()
        {
            // ARRANGE
            int a = 5;
            int b = 5;
            var expected = 10;
            var underTest = new Calcul();

            // ACT
            var actual = underTest.Additionner(a, b);

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
