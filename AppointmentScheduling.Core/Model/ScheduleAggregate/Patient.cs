using FrontDesk.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Model.ScheduleAggregate
{
    public class Patient : Entity<int>
    {
        public int ClientId { get; private set; }
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public AnimalType AnimalType { get; private set; }
        public int? PreferredDoctorId { get; set; }

        public Patient(int id)
            : base(id)
        {
        }

        private Patient()
        {

        }
    }
}
