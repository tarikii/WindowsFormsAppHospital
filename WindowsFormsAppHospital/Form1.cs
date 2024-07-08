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
    public partial class Form1 : Form
    {
        private List<Person> persons;
        private RegisterDoctorControl registerDoctorControl;
        private RegisterPatientControl registerPatientControl;
        private RegisterStaffControl registerStaffControl;
        private ListDoctorsControl listDoctorsControl;
        private ListPatientsControl listPatientsControl;
        private ListPersonsControl listPersonsControl;
        private RemovePatientControl removePatientControl;

        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butRegisterDoctor_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            registerDoctorControl = new RegisterDoctorControl(persons);

            registerDoctorControl.Location = new Point(189, 3);
            registerDoctorControl.Size = new Size(416, 590);

            this.Controls.Add(registerDoctorControl);
        }

        private void butRegisterPatient_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            registerPatientControl = new RegisterPatientControl(persons);

            registerPatientControl.Location = new Point(189, 3);
            registerPatientControl.Size = new Size(416, 590);

            this.Controls.Add(registerPatientControl);
        }

        private void butRegisterStaff_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            registerStaffControl = new RegisterStaffControl(persons);

            registerStaffControl.Location = new Point(189, 3);
            registerStaffControl.Size = new Size(416, 590);

            this.Controls.Add(registerStaffControl);
        }

        private void butListDoctors_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            listDoctorsControl = new ListDoctorsControl();

            listDoctorsControl.Location = new Point(189, 3);
            listDoctorsControl.Size = new Size(416, 590);

            this.Controls.Add(listDoctorsControl);

            foreach (Person person in persons)
            {
                if (person.GetType() == typeof(Doctor))
                {
                    Doctor doctor = (Doctor)person;
                    ListViewItem item = new ListViewItem(doctor.Name);

                    item.SubItems.Add(doctor.Age.ToString());
                    item.SubItems.Add(doctor.SpecialField);

                    listDoctorsControl.ListDoctorsView.Items.Add(item);
                }
            }
        }

        private void butListPatients_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            listPatientsControl = new ListPatientsControl();

            listPatientsControl.Location = new Point(189, 3);
            listPatientsControl.Size = new Size(416, 590);

            this.Controls.Add(listPatientsControl);

            

            foreach (Person person in persons)
            {
                if (person.GetType() == typeof(Patient))
                {
                    Patient patient = (Patient)person;
                    ListViewItem item = new ListViewItem(patient.Name);

                    item.SubItems.Add(patient.Age.ToString());
                    item.SubItems.Add(patient.Illness);
                    item.SubItems.Add(patient.AssignedDoctor.Name);

                    listPatientsControl.ListPatientsView.Items.Add(item);
                }
            }
        }

        private void butRemovePatient_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            removePatientControl = new RemovePatientControl(persons);

            removePatientControl.Location = new Point(189, 3);
            removePatientControl.Size = new Size(416, 590);

            this.Controls.Add(removePatientControl);
        }

        private void butListPersons_Click(object sender, EventArgs e)
        {
            RemoveOtherControls();

            listPersonsControl = new ListPersonsControl();

            listPersonsControl.Location = new Point(189, 3);
            listPersonsControl.Size = new Size(416, 590);

            this.Controls.Add(listPersonsControl);

            foreach (Person person in persons)
            {
                ListViewItem item = new ListViewItem(person.Name);

                item.SubItems.Add(person.Age.ToString());

                listPersonsControl.ListPersonsView.Items.Add(item);
            }
        }

        private void RemoveOtherControls()
        {
            if (registerDoctorControl != null)
            {
                this.Controls.Remove(registerDoctorControl);
                registerDoctorControl.Dispose();
                registerDoctorControl = null;
            }

            if (registerPatientControl != null)
            {
                this.Controls.Remove(registerPatientControl);
                registerPatientControl.Dispose();
                registerPatientControl = null;
            }

            if (registerStaffControl != null)
            {
                this.Controls.Remove(registerStaffControl);
                registerStaffControl.Dispose();
                registerStaffControl = null;
            }

            if (listDoctorsControl != null)
            {
                this.Controls.Remove(listDoctorsControl);
                listDoctorsControl.Dispose();
                listDoctorsControl = null;
            }

            if (listPatientsControl != null)
            {
                this.Controls.Remove(listPatientsControl);
                listPatientsControl.Dispose();
                listPatientsControl = null;
            }

            if (removePatientControl != null)
            {
                this.Controls.Remove(removePatientControl);
                removePatientControl.Dispose();
                removePatientControl = null;
            }

            if (listPersonsControl != null)
            {
                this.Controls.Remove(listPersonsControl);
                listPersonsControl.Dispose();
                listPersonsControl = null;
            }
        }
    }
}
