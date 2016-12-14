using System.Diagnostics;

namespace Tips.Entities
{
    public class Thing
    {
        public string Name
        {
            [DebuggerStepThrough]
            get; set;
        }

        [DebuggerStepThrough]
        public void Method1()
        {
            Method2();
        }

        private void Method2()
        {
        }
    }
}