using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class DebuggerStepThroughTest
    {
        [TestMethod]
        public void Example()
        {
            var t = new Thing();

            t.Method1();

            var n = t.Name;

            t.Name = "Mati";
        }

    }
}