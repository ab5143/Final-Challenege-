using System;
using Cafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_UnitTest
{
    [TestClass]
    public class Cafe_UnitTest
    {
        [TestMethod]
        public void SetCafe_ShouldSetCorrectString()
        {
            Meals meals = new Meals();

            meals.Description = "CheeseBurger";

            string expected = "CheeseBurger";
            string actual = meals.Description;

            Assert.AreEqual(expected, actual);

        }
    }
}
