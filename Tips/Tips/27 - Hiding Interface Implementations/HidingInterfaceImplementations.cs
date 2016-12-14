using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class HidingInterfaceImplementations
    {

        [TestMethod]
        public void Example()
        {
            var byClass = new SomeClass();

            byClass.MethodA();
            // byClass.MethodB();    // Error


            var byInterface = (ISomeInterface)byClass;

            byInterface.MethodA();
            byInterface.MethodB();
        }
    }
}