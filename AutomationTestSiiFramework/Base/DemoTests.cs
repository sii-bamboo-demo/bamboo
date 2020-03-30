using FluentAssertions;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BambooDemo.Base
{
    [AllureNUnit]
    [TestFixture]
    public class DemoTests 
    {
        [Test]
        public void ShouldPass()
        {
            1.Should().Be(1);
        }

        [Test]
        public void ShouldFail()
        {
            1.Should().Be(2);
        }
    }
}