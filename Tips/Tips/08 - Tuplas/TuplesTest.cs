using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class TuplesTest
    {
        [TestMethod]
        public void CreatingTuples()
        {
            // Constructor

            var tupleOneElement = new Tuple<int>(1);

            var tupleTwoElement = new Tuple<int, string>(1, "hello");

            var tupleFiveElement =
                new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5);

            var tupleSevenElement =
                new Tuple<int, int, int, int, int, int, Tuple<string>>(1, 2, 3, 4, 5, 6,
                                                                                        new Tuple<string>("hello"));


            // Static 

            var tupleThreeElement = Tuple.Create(42, "hello", DateTime.Now);
        }




        [TestMethod]
        public void AccessingTupleProperties()
        {
            var t = Tuple.Create(28, "Germán", "Küber");

            int age = t.Item1;
            string name = t.Item2;
            string lastName = t.Item3;


            //t.Item1 = 99;    //immutable
        }


        [TestMethod]
        public void ComparingTuples()
        {
            var t1 = Tuple.Create(42, "hello");
            var t2 = Tuple.Create(42, "hello");

            // Reference 
            var isEqualTuples = t1 == t2;

            // "value" 
            isEqualTuples = t1.Equals(t2);
        }




        [TestMethod]
        public void UsingTuplesToReturnMultipleValues()
        {
            var boxingOpponents = GetOpponentNames();

            var opponent1 = boxingOpponents.Item1;
            var opponent2 = boxingOpponents.Item2;
        }

        private Tuple<string, string> GetOpponentNames()
        {
            return new Tuple<string, string>("Fred", "Bob");
        }




        [TestMethod]
        public void UsingTuplesAsCompoundDictionaryKeys()
        {
            var t1 = Tuple.Create(1, "z");
            var t2 = Tuple.Create(2, "a");
            var t3 = Tuple.Create(1, "a");

            var d = new SortedDictionary<Tuple<int, string>, string>();

            d.Add(t1, "Tuple 1");
            d.Add(t2, "Tuple 2");
            d.Add(t3, "Tuple 3");

            foreach (var item in d)
            {
                Debug.WriteLine(item);
            }

            var t4 = Tuple.Create(1, "c");
            d.Add(t4, "tTuple 4");
            foreach (var item in d)
            {
                Debug.WriteLine(item);
            }
            var t5 = Tuple.Create(1, "z");

            d.Add(t5, "tTuple 5");
        }
    }
}
