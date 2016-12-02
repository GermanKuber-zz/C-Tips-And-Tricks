using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips
{
    [TestClass]
    public class StringNullEmptyTest
    {
        [TestMethod]
        public void IsNullTest()
        {
            var input = "";

            bool isNullOrEmpty = false;

            if (input == null || input == "")
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }
            var other = isNullOrEmpty;

        }
        [TestMethod]
        public void IsNullTest2()
        {
            var input = "";

            bool isNullOrEmpty;

            if (string.IsNullOrEmpty(input))
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }
            var other = isNullOrEmpty;
        }
        [TestMethod]
        public void IsNullTest3()
        {
            var input = "";

            bool isNullOrEmpty;

            if (string.IsNullOrWhiteSpace(input))
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }
            var other = isNullOrEmpty;
        }


    }
}
