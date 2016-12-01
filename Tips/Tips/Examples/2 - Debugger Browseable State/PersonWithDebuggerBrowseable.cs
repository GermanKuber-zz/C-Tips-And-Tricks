using System.Collections.Generic;
using System.Diagnostics;

namespace Tips.Examples
{
    public class PersonWithDebuggerBrowseable
    {
        public string Name { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int Age { get; set; }
        public string Information { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<string> Hobbies { get; set; }
    }
}
