using System.Diagnostics;

namespace Tips.Core.Entities
{
    [DebuggerDisplay("Esta persona se llama {Name} y su edad es {Age}. Alguna información extra : {Information}")]
    public class PersonWithDisplayValues
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Information { get; set; }
        public PersonType PersonType { get; set; }

    }
    [DebuggerDisplay("Tipo de persona")]
    public enum PersonType
    {
        Child,
        Adult
    }
}