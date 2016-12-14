namespace Tips
{
    class SomeClass : ISomeInterface
    {
        // Implicitly implemented
        public void MethodA()
        {
        }

        // Explicitly implemented
        void ISomeInterface.MethodB()
        {
        }
    }
}