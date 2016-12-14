using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class ConstrainingGenerics
    {

        [TestMethod]
        public void ByBaseClass()
        {
            // Invalid
            // new ConstrainedByBase<A>();

            new ConstrainedByBase<B>();

            new ConstrainedByBase<C>();
        }








        [TestMethod]
        public void ByInterfaceImplementation()
        {
            new ConstrainedByInterface<PrintableFoo>();

            // Invalid
            // new ConstrainedByInterface<string>();
        }











        [TestMethod]
        public void ByReferenceType()
        {
            new ConstrainedByReferenceType<string>();

            // Invalid
            // new ConstrainedByReferenceType<int>();
        }










        [TestMethod]
        public void ByValueType()
        {
            // Invalid
            // new ConstrainedByValueType<string>();

            new ConstrainedByValueType<int>();

            // Invalid - must be non-nullable value type
            // new ConstrainedByValueType<int?>();
        }









        [TestMethod]
        public void ByParameterlessCtor()
        {
            var ctor = new ConstrainedByCtor<FooWithCtor>();

            var x = ctor.CreateANewT();

            // Invalid
            // new ConstrainedByCtor<FooWithPrivateCtor>();

            // Invalid
            // new ConstrainedByCtor<FooWithParameterizedCtor>();
        }








        [TestMethod]
        public void ByCombinations()
        {
            // Invalid - not ICookable
            // new ConstrainedByCombinations<Orange>();

            // Invalid - no public parameterless ctor
            // new ConstrainedByCombinations<Pear>();

            new ConstrainedByCombinations<Apple>();
        }

    }
}