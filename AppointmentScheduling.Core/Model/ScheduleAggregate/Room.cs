using FrontDesk.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Model.ScheduleAggregate
{
    public class Room : Entity<int>
    {
        public virtual string Name { get; set; }

        public Room(int id)
            : base(id)
        {
        }
    }
}
