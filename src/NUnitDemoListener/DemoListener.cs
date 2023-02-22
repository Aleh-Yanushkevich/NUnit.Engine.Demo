using Demo.Shared;
using NUnit.Engine;
using NUnit.Engine.Extensibility;

namespace NUnitDemoListener
{
    [Extension(Description = "Demo Listener")]
    public class DemoListener : ITestEventListener
    {
        private readonly ExtensionManager extensionManager = new ExtensionManager();

        public void OnTestEvent(string report)
        {
        }

        public DemoListener()
        {
            // Do something with extensionManager field.
        }
    }
}