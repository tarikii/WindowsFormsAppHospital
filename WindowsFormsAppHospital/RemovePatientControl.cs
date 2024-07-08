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
    public partial class RemovePatientControl : UserControl
    {
        private List<Person> persons;
        public RemovePatientControl(List<Person> persons)
        {
            InitializeComponent();
            foreach (Person person in persons)
            {
                if (person.GetType() == typeof(Patient))
                {
                    listPatientsComboBox.Items.Add(person.Name);
                }
            }
            this.persons = persons;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void butRemovePatient_Click(object sender, EventArgs e)
        {
            string namePatient = listPatientsComboBox.SelectedItem.ToString();
            bool patientFound = false;

            for (int i = persons.Count - 1; i >= 0; i--)
            {
                if (persons[i].Name == namePatient)
                {
                    persons.RemoveAt(i);
                    patientFound = true;

                    MessageBox.Show("Patient removed successfully!", "Patient removed",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    break;
                }
            }

            if (!patientFound)
            {
                MessageBox.Show("Patient not found!", "Patient does not exist",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
