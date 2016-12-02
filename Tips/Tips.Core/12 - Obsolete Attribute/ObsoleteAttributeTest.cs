using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tips.Core
{
    [TestClass]
    public class ObsoleteAttributeTest
    {
        [TestMethod]
        public void ObsoleteTest()
        {


            //var clas1 = new UseAtTheClassLevel();

            //var clas2 = new UseAtTheClassLevelWithMessage();

            //var a = new UseOnIndividualMembers();
            //a.Name = "Sarah";

            //var errorTest = new UseAtTheClassLevelWithCompilerError();
        }
    }

    [Obsolete]
    public class UseAtTheClassLevel { }


    [Obsolete("Utilice la clase 'XxX' ya que esta clase dejare de existir")]
    public class UseAtTheClassLevelWithMessage { }


    public class UseOnIndividualMembers
    {
        [Obsolete("Utilice la propieadad FullName de ahora en adelante")]
        public string Name { get; set; }

        public string FullName { get; set; }
    }

    [Obsolete("Esta clase no funciona mas, pruebe usando 'XxX'", true)]
    public class UseAtTheClassLevelWithCompilerError { }
}
