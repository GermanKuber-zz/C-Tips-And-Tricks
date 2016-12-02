using System;

namespace Tips.Entities
{
    class ExceptionClass
    {
        public void NoStacktrace()
        {
            try
            {
                MethodA();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void WithStacktrace()
        {
            try
            {
                MethodA();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void MethodA()
        {
            MethodB();
        }

        private void MethodB()
        {
            MethodC();
        }

        private void MethodC()
        {
            throw new ApplicationException("First Exception");
        }
    }
}