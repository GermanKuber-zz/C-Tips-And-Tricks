using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Core.Entities;

namespace Tips.Core
{
    [TestClass]
    public class StringNullEmptyTest
    {
        [TestMethod]
        public void IsNullTest()
        {
            var input = "";

            bool isNullOrEmpty;

            if (input == null || input == "")
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }

        }
        [TestMethod]
        public void IsNullTest2()
        {
            var input = "";

            bool isNullOrEmpty;

            if (string.IsNullOrEmpty(input))
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }

        }
        [TestMethod]
        public void IsNullTest3()
        {
            var input = "";

            bool isNullOrEmpty;

            if (string.IsNullOrWhiteSpace(input))
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }

        }


    }
}
