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
    }
}
