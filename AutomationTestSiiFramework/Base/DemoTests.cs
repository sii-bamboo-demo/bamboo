using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BambooDemo.Base
{
    // [AllureNUnit]
    public class DemoTests 
    {
        [TestMethod]
        public void ShouldPass()
        {
            1.Should().Be(1);
        }

        [TestMethod]
        public void ShouldFail()
        {
            1.Should().Be(2);
        }
    }
}