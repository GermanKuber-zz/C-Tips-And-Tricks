using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Tips.Entities
{
    [DebuggerTypeProxy(typeof(PersonDebugProxy))]
    public class PersonPro
    {
        private readonly string _name;

        public PersonPro(string name)
        {
            _name = name;
            FavouriteColors = new SortedList<int, string>();
        }

        public int Age { get; set; }
        public SortedList<int, string> FavouriteColors { get; set; }



        // Internal nested class so we can access the internals of the object being proxied
        private class PersonDebugProxy
        {
            private readonly PersonPro _objectToProxy;

            public PersonDebugProxy(PersonPro objectToProxy)
            {
                _objectToProxy = objectToProxy;
            }

            public string PersonalDetails => $"{_objectToProxy._name}, {_objectToProxy.Age} años";

            public string MostFavouriteColor
            {
                get
                {
                    if (_objectToProxy.FavouriteColors.Any())
                    {
                        return _objectToProxy.FavouriteColors.First().Value;
                    }

                    return "No tiene color favorito";
                }
            }
        }
    }
}