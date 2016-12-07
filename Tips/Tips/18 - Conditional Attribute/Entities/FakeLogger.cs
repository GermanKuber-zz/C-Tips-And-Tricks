using System.Diagnostics;

namespace Tips.Entities
{
    class FakeLogger
    {
        [Conditional("LOG")]
        public void WriteLogMessage(string message)
        {
            Debug.WriteLine("DEBUG MESSAGE: " + message);
        }
    }
}