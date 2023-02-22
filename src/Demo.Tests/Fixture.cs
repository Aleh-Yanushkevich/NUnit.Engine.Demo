﻿using Demo.Shared;
using NUnit.Framework;

namespace Demo.Tests
{
    [TestFixture]
    public class Fixture
    {
        [Test]
        public void Test()
        {
            // Just for loading assembly into domain.
            var extensionManager = Context.Instance;

            /**
             For NUnit.Engine up to 3.16 Demo.Shared assembly is loaded only once (during initialization an instance of ExtensionManager in DemoListener class).
             For NUnit.Engine 3.16+ - twice (in DemoListener and here).
             */
            Assert.Pass();
        }
    }
}