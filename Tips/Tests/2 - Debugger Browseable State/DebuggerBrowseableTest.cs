using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Examples;

namespace Tests
{
    [TestClass]
    public class DebuggerBrowseableTest
    {
        [TestMethod]
        public void PersonWithOutDebuggerBrowseableTest()
        {
            var values = new PersonWithOutDebuggerBrowseable
            {
                Age = 28,
                Information = "Nueva información",
                Name = "Germán",
                Hobbies = new List<string>
                {
                    "Programar",
                    "Diseñar",
                    "Trabajar"
                }
            };
        }


        [TestMethod]
        public void PersonWithDisplayValuesTest()
        {
            var values = new PersonWithDebuggerBrowseable
            {
                Age = 28,
                Information = "Nueva información",
                Name = "Germán",
                Hobbies = new List<string>
                {
                    "Programar",
                    "Diseñar",
                    "Trabajar"
                }
            };
        }


    }
}
