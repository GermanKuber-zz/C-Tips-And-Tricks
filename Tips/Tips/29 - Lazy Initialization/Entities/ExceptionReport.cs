using System;
using System.Diagnostics;

namespace Tips.Entities
{
    public class ExceptionReport
    {
        public ExceptionReport()
        {
            Debug.WriteLine("*********** Creating ExceptionReport *********** ");

            throw new ApplicationException("Ex time: " + DateTime.Now.ToLongTimeString());
        }

        public void DoSomething()
        {
        }
    }
}