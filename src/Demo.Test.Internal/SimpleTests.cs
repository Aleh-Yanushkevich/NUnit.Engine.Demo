using NUnit.Engine;
using NUnit.Framework;
using NUnitDemoListener;

namespace Demo.Test.Internal
{
    [TestFixture]
    public class TestEngineFixture
    {
        private readonly TestPackage testPackage = new TestPackage("Demo.Tests.dll");

        [Test]
        public void Test()
        {
            var listener = new DemoListener();

            var testRunner = new TestEngine().GetRunner(testPackage);

            var node = testRunner.Run(listener, TestFilter.Empty);

            var failed = node.SelectNodes("//test-case[@result=\"Failed\"]");

            Assert.That(failed!.Count, Is.EqualTo(0));
        }
    }
}