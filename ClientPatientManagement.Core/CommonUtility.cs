using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core
{
    public class CommonUtility
    {
        public static CommonUtility Instance;

        private CommonUtility()
        {
            Instance = new CommonUtility();
        }

        private void ToReas()
        {
            Console.WriteLine("Common");
        }
    }
}
