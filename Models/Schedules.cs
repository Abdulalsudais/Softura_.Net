using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Models
{
    public class Schedules
    {
        public int AppointmentID { get; set; }
        public string Specializations { get; set; }
        public string DoctorName { get; set; }
        public string patientName { get; set; }
        public string VisitDate { get; set; }
        public string AppointmentTime { get; set; }
    }
}
