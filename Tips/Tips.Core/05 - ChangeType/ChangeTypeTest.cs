using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Core.Entities;

namespace Tips.Core
{
    [TestClass]
    public class ChangeTypeTest
    {
        [TestMethod]
        public void ChangeTest()
        {
            Type typeToConvert;
            Type convertedType;

            object initialValue;
            object convertedValue;


            initialValue = "1";

            typeToConvert = typeof(int);


            convertedValue = Convert.ChangeType(initialValue, typeToConvert);

            convertedType = convertedValue.GetType();

            typeToConvert = typeof(decimal);

            convertedValue = Convert.ChangeType(initialValue, typeToConvert);

            convertedType = convertedValue.GetType();



        }



    }
}
