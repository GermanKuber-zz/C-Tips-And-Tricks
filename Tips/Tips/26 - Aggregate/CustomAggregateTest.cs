using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class CustomAggregateTest
    {

        [TestMethod]
        public void WithSeedValue()
        {
            var numbers = new[] { 5, 10, 20 };




            var first = numbers.Aggregate(0,
                (total, item) => total + item);

            var Second = numbers.Aggregate(100,
                (total, item) => total + item);
        }









        [TestMethod]
        public void NoSeedValue()
        {
            var nums = new[] { 10, 2, 3, 4 };

            var resultWithSeed = nums.Aggregate(100, CustomAccumulationFunction);
            var resultWithNoSeed = nums.Aggregate(CustomAccumulationFunction);
        }

        private int CustomAccumulationFunction(int runningTotal, int num)
        {
            if (num % 2 == 0)
            {
                return runningTotal + num;
            }

            return runningTotal;
        }
    }
}