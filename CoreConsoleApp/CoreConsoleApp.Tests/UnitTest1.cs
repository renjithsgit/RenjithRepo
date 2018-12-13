using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CoreConsoleApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        [DataTestMethod]
        public void TestDataFromExternalSource()
        {
            IEnumerable<object[]> tsData = DataFromExtrnalSource.GetData();
            Assert.IsTrue(true);

        }

        [TestMethod]
        public void TestCustomAssert()
        {
            Assert.That.IsInRange(3, 2, 5);
        }
    }
}
