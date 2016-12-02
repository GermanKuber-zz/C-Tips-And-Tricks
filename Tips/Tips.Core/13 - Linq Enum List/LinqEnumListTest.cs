using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips.Core
{
    [TestClass]
    public class LinqEnumListTest
    {
        [TestMethod]
        public void Enumerator()
        {
            var nums = new List<int> { 1, 2, 3, 4 };

            var q = from n in nums
                    select new
                    {
                        Number = n,
                        ExecutionTime = DateTime.Now.ToString("mm:ss:fff")
                    };

            Debug.WriteLine("1º Enumeración");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }

            Debug.WriteLine("2º Enumeración");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }
        }


        [TestMethod]
        public void List()
        {
            var nums = new List<int> { 1, 2, 3, 4 };

            var q = (from n in nums
                     select new
                     {
                         Number = n,
                         ExecutionTime = DateTime.Now.ToString("mm:ss:fff")
                     }).ToList();

            Debug.WriteLine("1º Lista");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }

            Debug.WriteLine("2º Lista");
            foreach (var n in q)
            {
                Debug.WriteLine(n);
            }
        }
    }
}
