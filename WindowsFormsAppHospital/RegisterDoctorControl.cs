﻿using System;
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
    public partial class RegisterDoctorControl : UserControl
    {
        private List<Person> persons;

        public RegisterDoctorControl(List<Person> persons)
        {
            InitializeComponent();
            this.persons = persons;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void butSubmitDoctor_Click(object sender, EventArgs e)
        {
            string nameDoctor = nameDoctorTextBox.Text;
            int ageDoctor = int.Parse(ageDoctorTextBox.Text);
            string specialField = specialFieldTextBox.Text;

            Doctor doctor = new Doctor(nameDoctor, ageDoctor, specialField);

            persons.Add(doctor);

            MessageBox.Show("Doctor created successfully!", "Doctor registered",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Visible = false;
        }
    }
}
