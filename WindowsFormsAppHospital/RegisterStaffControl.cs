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
            int ageStaff;
            bool tryParse;

            string nameStaff = nameStaffTextBox.Text;
            string ageStaffText = ageStaffTextBox.Text;
            string department = departmentTextBox.Text;

            tryParse = int.TryParse(ageStaffText, out ageStaff);

            if (!tryParse)
            {
                MessageBox.Show("Staff age is not valid!", "Invalid age!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Visible = false;
            }

            else
            {
                Staff staff = new Staff(nameStaff, ageStaff, department);

                persons.Add(staff);

                MessageBox.Show("Staff created successfully!", "Staff registered",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Visible = false;
            }
        }
    }
}
