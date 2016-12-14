using System.Diagnostics;

namespace Tips.Entities
{
    public class Thing
    {
        //Enable Just My Code
        private string _name;

        public string Name
        {
            [DebuggerStepThrough]
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
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