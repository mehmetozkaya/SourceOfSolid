using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduling.Core.Interfaces
{
    public interface IApplicationSettings
    {
        int ClinicId { get; }
        DateTime TestDate { get; }
    }
}
