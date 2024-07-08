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
    public partial class RegisterPatientControl : UserControl
    {
        private List<Person> persons;

        public RegisterPatientControl(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void butSubmitPatient_Click(object sender, EventArgs e)
        {
            int agePatient;
            bool tryParse;

            string namePatient = namePatientTextBox.Text;
            string agePatientText = agePatientTextBox.Text;
            string illness = illnessTextBox.Text;

            tryParse = int.TryParse(agePatientText, out agePatient);

            if (!tryParse)
            {
                MessageBox.Show("Patient age is not valid!", "Invalid age!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Visible = false;
            }

            else
            {
                string doctorName = doctorAssignedTextBox.Text;
                Doctor assignedDoctor = persons.OfType<Doctor>().FirstOrDefault(d => d.Name == doctorName);

                if (assignedDoctor == null)
                {
                    MessageBox.Show("Doctor not found!", "Info not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Visible = false;
                }

                else
                {
                    Patient patient = new Patient(namePatient, agePatient, illness, assignedDoctor);

                    persons.Add(patient);

                    MessageBox.Show("Patient created successfully!", "Patient registered",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                }
            }
        }
    }
}
