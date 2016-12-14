using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tips.Entities;

namespace Tips
{
    [TestClass]
    public class DebuggerProxyTest
    {
        [TestMethod]
        public void Example()
        {
            var p = new PersonPro("Germán") { Age = 33 };


            p.FavouriteColors.Add(2, "Rojo");
            p.FavouriteColors.Add(1, "Verde");
            p.FavouriteColors.Add(3, "Amarillo");
        }
    }
}