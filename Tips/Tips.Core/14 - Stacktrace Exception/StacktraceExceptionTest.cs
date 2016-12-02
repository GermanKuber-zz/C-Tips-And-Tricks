using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Core.Entities;

namespace Tips.Core
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
