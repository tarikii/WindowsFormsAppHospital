using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHospital
{
    public class Staff : Person
    {
        public string Department { get; }

        public Staff(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Department: {Department}";
        }
    }
}
