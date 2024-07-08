using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHospital
{
    public class Patient : Person
    {

        public Doctor AssignedDoctor { get; set; }
        public string Illness { get; set; }

        public Patient(string name, int age, string illness, Doctor assignedDoctor) : base(name, age)
        {
            Illness = illness;
            AssignedDoctor = assignedDoctor;
        }

        public Patient()
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"; Illness: {Illness}; Assigned Doctor: {AssignedDoctor.Name}";
        }
    }
}
