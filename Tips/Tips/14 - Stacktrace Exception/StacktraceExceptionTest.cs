using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class StacktraceExceptionTest
    {
        [TestMethod]
        public void NoStacktraceTest()
        {
            var w = new ExceptionClass();

            w.NoStacktrace();
        }


        [TestMethod]
        public void WithStacktraceTest()
        {
            var w = new ExceptionClass();

            w.WithStacktrace();
        }
    }
}
