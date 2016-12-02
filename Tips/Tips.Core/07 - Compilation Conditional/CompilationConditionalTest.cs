using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Core.Entities;

namespace Tips.Core
{
    [TestClass]
    public class CompilationConditionalTest
    {
        [TestMethod]
        public void CompilationConditional()
        {
            string text = "";

#if DEBUG
            text = "Debug";
#elif RELEASE
            text = "Release";
#else
            text = "Other";
#endif
            var other = text;

        }
        [TestMethod]
        public void CompilationConditional1()
        {
            //#warning Mensaje Random

            //#if DEBUG && RELEASE
            //#error No se puede compilar RELEASE y DEBUG al mismo tiempo

            //#endif

        }



    }
}
