using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public static class IEnumerableExtensions
    {
        public static bool HasData<T>(this IEnumerable<T> source)
        {
            if(source == null)
            {
                return false;
            }

            bool containsData = source.Count() > 0;
            return containsData;
        }
    }
}
