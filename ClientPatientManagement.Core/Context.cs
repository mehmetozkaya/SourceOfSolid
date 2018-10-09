using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public class Context<T>
    {
        private Dictionary<int, T> _dictionaryContext;
    }
}
