using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetOffice.SharedDatabase.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Proficience { get; set; }

        public Doctor(int doctorId)
        {
            DoctorId = doctorId;
        }

    }
}
