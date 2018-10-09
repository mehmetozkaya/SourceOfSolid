using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    internal class Context<T>
    {
        private readonly Dictionary<int, T> _dictionaryContext;
        public String Name { get; private set; }

        public Context(Dictionary<int, T> dictionaryContext, string name)
        {
            _dictionaryContext = dictionaryContext;
            Name = name;
        }

        public int Count
        {
            get { return _dictionaryContext.Count(); }
        }
        public Dictionary<int, T>.KeyCollection Keys
        {
            get { return _dictionaryContext.Keys; }
        }
        public Dictionary<int, T>.ValueCollection Values
        {
            get { return _dictionaryContext.Values; }
        }

        public void Add(int key, T value)
        {
            _dictionaryContext.Add(key, value);
        }

        public bool Remove(int key)
        {
            return _dictionaryContext.Remove(key);
        }
    }
}
