using CSharp.Biz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Biz.Tests
{
    [TestClass()]
    public class CollectionsTests
    {
        [TestMethod()]
        public void CollectionsTest()
        {
            var currentProduct = new Collections();
            currentProduct.CollectionsName = "Saw";

            string expected = "Saw";
            string expectedMessage = null;

            var actual = currentProduct.CollectionsName;
            var actualMessage = currentProduct.ValidationMessage;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}