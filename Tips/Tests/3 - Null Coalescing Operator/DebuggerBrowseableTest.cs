using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class NullCoalescingOperatorTest
    {
        [TestMethod]
        public void CheckNullTraditional()
        {
            var name = "Nombre";
            var result = "";

            if (name == null)
            {
                result = "Nombre no ingresado";
            }
            else
            {
                result = name;
            }
        }
        [TestMethod]
        public void CheckCoalesciengNull()
        {
            var name = "Nombre";
            var result = "";


            result = name ?? "Nombre no ingresado";


            name = null;

            result = name ?? "Nombre no ingresado";

        }

        [TestMethod]
        public void CheckCoalesciengNullConcat()
        {
            int? firstValue = null;
            int secondValue = 26;

            int? age = null;


            int result = age ?? firstValue ?? secondValue;

        }



    }
}
