using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BambooDemo
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ShouldPass()
        {
            Assert.AreEqual(10, 10);
        }


        [TestMethod]
        public void ShouldFail()
        {
            Assert.AreEqual(10, 11);
        }
    }
}
