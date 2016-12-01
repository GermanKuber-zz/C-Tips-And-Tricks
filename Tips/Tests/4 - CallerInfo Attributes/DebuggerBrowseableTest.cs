using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Examples;

namespace Tests
{
    [TestClass]
    public class CallerInfoAttributesTest
    {
        [TestMethod]
        public void CallerInfoAttributesMethodTest()
        {
            var c = new CallerInfoAttribute();

            Debug.WriteLine(c.WhoCalledMe());

            Debug.WriteLine(c.WhatFileCalledMe());

            Debug.WriteLine(c.WhatLineCalledMe());
        }

        [TestMethod]
        public void CallerInfoAttributesPropertyChangeTest()
        {
            var objChange = new CallerInfoAttributesClass();

            objChange.Age = 2;

            objChange.Information = "Nueva información";

            objChange.Name = "Test Name";
        }

    }
}
