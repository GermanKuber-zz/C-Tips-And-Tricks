using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class UnionLinqTest
    {

        [TestMethod]
        public void Concat()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Concat(fiveToTen);
        }










        [TestMethod]
        public void Union()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Union(fiveToTen);
        }









        [TestMethod]
        public void Intersect()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Intersect(fiveToTen);
        }










        [TestMethod]
        public void Except()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Except(fiveToTen);




            var l1 = new List<A> { new A { Name = "A" } };
            var l2 = new List<A> { new A { Name = "A" } };

            var results = l1.Except(l2);
        }
    }

    public class A
    {
        public string Name { get; set; }
    }
}