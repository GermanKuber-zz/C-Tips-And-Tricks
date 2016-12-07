using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class BreakAndContinueTest
    {
        [TestMethod]
        public void BreakFromLoop()
        {
            var i = 10;

            while (true)
            {
                i--;

                if (i == 5)
                {
                    break;
                }
            }

            for (int j = 0; j < 1000; j++)
            {
                i = j;

                if (j == 50)
                {
                    break;
                }
            }
        }


        [TestMethod]
        public void SkipRemainingLoop()
        {
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                Debug.WriteLine(i);
            }
        }
    }
}
