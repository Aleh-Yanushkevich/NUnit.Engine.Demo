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

            testRunner.Run(listener, TestFilter.Empty);
        }
    }
}