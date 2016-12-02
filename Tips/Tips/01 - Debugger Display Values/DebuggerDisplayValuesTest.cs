using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class DebuggerDisplayValuesTest
    {
        [TestMethod]
        public void PersonWithOutDisplayValuesTest()
        {
            var values = new PersonWitOuthDisplayValues
            {
                Age = 28,
                Information = "Nueva información",
                Name = "Germán"
            };
        }


        [TestMethod]
        public void PersonWithDisplayValuesTest()
        {
            var values = new PersonWithDisplayValues
            {
                Age = 28,
                Information = "Nueva información",
                Name = "Germán"
            };
        }


        //Clases
        //Structs
        //Delegates
        //Enums
        //Fields
        //Properties
        //Assemblies
    }
}
