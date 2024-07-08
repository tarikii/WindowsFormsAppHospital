using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHospital
{
    public partial class RegisterStaffControl : UserControl
    {
        private List<Person> persons;
        public RegisterStaffControl(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void RegisterStaffControl_Load(object sender, EventArgs e)
        {

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void butSubmitStaff_Click(object sender, EventArgs e)
        {
            string nameStaff = nameStaffTextBox.Text;
            int ageStaff = int.Parse(ageStaffTextBox.Text);
            string department = departmentTextBox.Text;

            Staff staff = new Staff(nameStaff, ageStaff, department);

            persons.Add(staff);

            MessageBox.Show("Staff created successfully!", "Staff registered",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Visible = false;
        }
    }
}
