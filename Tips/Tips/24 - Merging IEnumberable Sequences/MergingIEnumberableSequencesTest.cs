using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class MergingIEnumberableSequencesTest
    {

        [TestMethod]
        public void EqualLengthSequences()
        {
            var names = new[] { "Matias", "Fede", "Juan" };

            var ages = new[] { 20, 28, 31 };

            var namesAndAges = names.Zip(ages, CombineNameAndAge).ToList();
        }


        private string CombineNameAndAge(string name, int age)
        {
            return name + ": " + age;
        }



        [TestMethod]
        public void DifferentLengthSequences()
        {
            var names = new[] { "Matias", "Fede", "Juan", "Nico" };

            var ages = new[] { 20, 28, 31 };


            var namesAndAges = names.Zip(ages, (name, age) => name + ": " + age);
        }


        [TestMethod]
        public void CreatingObjects()
        {
            var names = new[] { "Matias", "Fede", "Juan" };

            var ages = new[] { 20, 28, 31 };

            var namesAndAges = names.Zip(ages, (name, age) => Tuple.Create(name, age));


            namesAndAges = names.Zip(ages, Tuple.Create);
        }

    }
}