using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lynq2
{
    class Day26Task
    {
        public static void Main()
        {

            IList<Doctor> DocData = new List<Doctor>()
            {
                new Doctor() { DoctorID = 1, DoctorName = "Abdul", Age = 39, SpecializedId = 1},
                new Doctor() { DoctorID = 2, DoctorName = "Giri", Age = 40, SpecializedId = 2},
                new Doctor() { DoctorID = 3, DoctorName = "John", Age = 36, SpecializedId = 5},
                new Doctor() { DoctorID = 4, DoctorName = "Sid", Age = 34, SpecializedId = 2},
                new Doctor() { DoctorID = 5, DoctorName = "Haris", Age = 36, SpecializedId = 4},
                new Doctor() { DoctorID = 6, DoctorName = "Dilli", Age = 38, SpecializedId = 1},
                new Doctor() { DoctorID = 7, DoctorName = "Nithin", Age = 34, SpecializedId = 6},
                new Doctor() { DoctorID = 8, DoctorName = "Santhosh", Age = 32, SpecializedId = 3},
                new Doctor() { DoctorID = 9, DoctorName = "Vishal", Age = 38, SpecializedId = 3},
                new Doctor() { DoctorID = 10, DoctorName = "Aanandh", Age = 37, SpecializedId = 4},
                new Doctor() { DoctorID = 11, DoctorName = "Pawan", Age = 35, SpecializedId = 6},
            };

            IList<Specialisation> SpecialisationData = new List<Specialisation>()
            {
                new Specialisation() {SpecializedId = 1,Specialized = "General Surgery"},
                new Specialisation() {SpecializedId = 2,Specialized = "Obstetrics & Gynaecology"},
                new Specialisation() {SpecializedId = 3,Specialized = "Ophthalmology"},
                new Specialisation() {SpecializedId = 4,Specialized = "Orthopedics"},
                new Specialisation() {SpecializedId = 5,Specialized = "Neurology"},
                new Specialisation() {SpecializedId = 6,Specialized = "Anaesthesiology"},

            };

            var DocGr = from SD in SpecialisationData
                        join DD in DocData
                        on SD.SpecializedId equals DD.SpecializedId
                        into DocGroup
                        select new
                        {
                            Doctors = DocGroup,
                            Specialisation = SD.Specialized
                        };
            foreach (var item in DocGr)
            {
                Console.WriteLine(item.Specialisation);
                foreach (var Doc in item.Doctors)
                    Console.WriteLine(Doc.DoctorName);
            }
        }
}

    public class Specialisation
    {
        public int SpecializedId { get; set; }
        public string Specialized { get; set; }
    }

    public class Doctor
    {

        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public int Age { get; set; }
        public int SpecializedId { get; set; }
    }
}
