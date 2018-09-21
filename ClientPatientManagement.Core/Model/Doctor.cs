using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPatientManagement.Core.Model
{
    public class Doctor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Doctor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        private void WriteDown(string id, string name)
        {
            Console.WriteLine(ToString);
        }

        private string ToString => $"{Name} and the unique {Id}";
    }

    internal class EntityManager<T> where T : class
    {

    }
}
