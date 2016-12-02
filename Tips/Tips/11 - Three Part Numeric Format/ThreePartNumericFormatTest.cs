using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class ThreePartNumericFormatTest
    {
        [TestMethod]
        public void Example()
        {
            const double positiveNumber = 99.99;
            const double negativeNumber = -23.55;
            const double zeroNumber = 0;


            const string threePartFormat = "(Positivo)#.##;(Negativo)#.##;(Número Cero)";


            var positiveOutput = positiveNumber.ToString(threePartFormat);
            var negativeOutput = negativeNumber.ToString(threePartFormat);
            var zeroOutput = zeroNumber.ToString(threePartFormat);


            Debug.IndentLevel = 10;
            Debug.WriteLine(positiveNumber);
            Debug.WriteLine(negativeOutput);
            Debug.WriteLine(zeroOutput);
        }
    }
}
