using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;
namespace Tips
{

    [TestClass]
    public class ImplicitExplicitTest
    {



        [TestMethod]
        public void ExplictTest()
        {
            Fahrenheit fahr = new Fahrenheit(100.0f);

            Console.Write("{0} Fahrenheit", fahr.Degrees);

            Celsius c = (Celsius)fahr;

            Console.Write(" = {0} Celsius", c.Degrees);
            Fahrenheit fahr2 = (Fahrenheit)c;
            Console.WriteLine(" = {0} Fahrenheit", fahr2.Degrees);

        }
        [TestMethod]
        public void ImplicitTest()
        {
            Digit dig = new Digit(7);

            double num = dig;

            Digit dig2 = 12;
            Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);


        }




    }
}
