using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
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
