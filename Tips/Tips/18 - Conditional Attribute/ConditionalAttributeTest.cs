using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class ConditionalAttributeTest
    {

        [TestMethod]
        public void UsingConditionalDirectives()
        {
            var logger = new FakeLogger();

#if LOG
            logger.WriteLogMessage("Message 1");
#endif

#if LOG
            logger.WriteLogMessage("Message 2");
#endif

        }







        [TestMethod]
        public void UsingConditionalAttribute()
        {
            var logger = new FakeLogger();

            logger.WriteLogMessage("Message 1");

            logger.WriteLogMessage("Message 2");
        }

    }
}
