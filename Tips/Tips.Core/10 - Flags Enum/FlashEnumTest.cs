using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class FlashEnumTest
    {
        [Flags]
        enum Alignments
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8
        }





        [TestMethod]
        public void Example()
        {
            // Seteo los valores
            var topRightCombination = Alignments.Top | Alignments.Right;
            var bottomLeftCombination = Alignments.Bottom | Alignments.Left;

            var isTopIncluded = (topRightCombination & Alignments.Top) != 0;

            var isNoneIncluded = (topRightCombination & Alignments.None) != 0;

            isTopIncluded = topRightCombination.HasFlag(Alignments.Top);




            // Combino las combinaciones         
            var all = topRightCombination | bottomLeftCombination;

            // Cambio values
            all ^= Alignments.Top;

            all ^= Alignments.Top;

        }
    }
}
