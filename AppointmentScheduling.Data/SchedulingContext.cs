using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Data
{
    public class SchedulingContext : DbContext
    {
        public SchedulingContext()
     : base("name=VetOfficeContext")
        {
        }


    }
}
