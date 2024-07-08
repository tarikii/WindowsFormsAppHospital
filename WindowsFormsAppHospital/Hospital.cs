using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHospital
{
    public class Hospital
    {
        public List<Person> Persons { get; set; }

        public Hospital()
        {
            Persons = new List<Person>();
        }

        public void RegisterDoctor(string name, int age, string specialField)
        {
            Doctor doctor = new Doctor(name, age, specialField);
            Persons.Add(doctor);
        }

        public void RegisterPatient(string name, int age, string illness, Doctor assignedDoctor)
        {
            Patient patient = new Patient(name, age, illness, assignedDoctor);
            Persons.Add(patient);
        }

        public void RegisterStaff(string name, int age, string department)
        {
            Staff staff = new Staff(name, age, department);
            Persons.Add(staff);
        }
    }
}
