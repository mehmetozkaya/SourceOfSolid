using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Data
{
    public class Class1
    {
    }

    internal abstract class Position
    {
        public abstract string Title { get; }
    }

    internal class Manager : Position
    {
        public override string Title
        {
            get
            {
                return "Manager";
            }
        }
    }

    public static class Factory
    {
        /// <summary>
        /// Decides which class to instantiate.
        /// </summary>
        public static Position Get(int id)
        {
            switch (id)
            {
                case 0:
                    return new Manager();
                case 1:
                case 2:
                    return new Clerk();
                case 3:
                default:
                    return new Programmer();
            }
        }
    }


}
