using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public class Context<T>
    {
        private readonly Dictionary<int, T> _dictionaryContext;
        public String Name { get; private set; }

        public Context(Dictionary<int, T> dictionaryContext, string name)
        {
            _dictionaryContext = dictionaryContext;
            Name = name;
        }
    }
}
