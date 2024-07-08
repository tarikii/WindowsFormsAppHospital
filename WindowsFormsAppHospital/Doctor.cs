using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHospital
{
    public class Doctor : Person
    {

        public List<Patient> Patients { get; set; }
        public string SpecialField { get; set; }

        public Doctor(string name, int age, string specialField) : base(name, age)
        {
            SpecialField = specialField;
            Patients = new List<Patient>();
        }

        public Doctor()
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"; Speciality: {SpecialField}";
        }
    }
}
