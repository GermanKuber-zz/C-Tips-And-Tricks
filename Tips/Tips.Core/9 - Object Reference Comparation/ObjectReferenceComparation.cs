using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips.Core
{
    [TestClass]
    public class ObjectReferenceComparationTest
    {
        [TestMethod]
        public void CompareReferenceTest()
        {
            var a = new TestClass { Name = "First Name" };
            var b = new TestClass { Name = "First Name" };

            var isEqual = a == b;

            var isSameReference = object.ReferenceEquals(a, b);

            b = a;

            isSameReference = object.ReferenceEquals(a, b);
        }






        [TestMethod]
        public void ExampleWithStringLiterals()
        {
            var s1 = "Hello";
            var s2 = "Hello";

            var isSameReference = object.ReferenceEquals(s1, s2);
        }
    }




    class TestClass
    {
        public string Name { get; set; }
    }
}
