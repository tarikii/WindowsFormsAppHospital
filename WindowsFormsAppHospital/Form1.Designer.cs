namespace WindowsFormsAppHospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.hospitalEsplai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butListPersons = new System.Windows.Forms.Button();
            this.butRemovePatient = new System.Windows.Forms.Button();
            this.butListPatients = new System.Windows.Forms.Button();
            this.butListDoctors = new System.Windows.Forms.Button();
            this.butRegisterStaff = new System.Windows.Forms.Button();
            this.butRegisterPatient = new System.Windows.Forms.Button();
            this.butRegisterDoctor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hospitalEsplai
            // 
            this.hospitalEsplai.AutoSize = true;
            this.hospitalEsplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalEsplai.ForeColor = System.Drawing.Color.White;
            this.hospitalEsplai.Location = new System.Drawing.Point(20, 5);
            this.hospitalEsplai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hospitalEsplai.Name = "hospitalEsplai";
            this.hospitalEsplai.Size = new System.Drawing.Size(148, 24);
            this.hospitalEsplai.TabIndex = 0;
            this.hospitalEsplai.Text = "Hospital Esplai";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.butListPersons);
            this.panel1.Controls.Add(this.butRemovePatient);
            this.panel1.Controls.Add(this.butListPatients);
            this.panel1.Controls.Add(this.butListDoctors);
            this.panel1.Controls.Add(this.butRegisterStaff);
            this.panel1.Controls.Add(this.butRegisterPatient);
            this.panel1.Controls.Add(this.butRegisterDoctor);
            this.panel1.Controls.Add(this.hospitalEsplai);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 590);
            this.panel1.TabIndex = 1;
            // 
            // butListPersons
            // 
            this.butListPersons.BackColor = System.Drawing.Color.Violet;
            this.butListPersons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butListPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListPersons.ForeColor = System.Drawing.Color.White;
            this.butListPersons.Location = new System.Drawing.Point(34, 500);
            this.butListPersons.Margin = new System.Windows.Forms.Padding(2);
            this.butListPersons.Name = "butListPersons";
            this.butListPersons.Size = new System.Drawing.Size(104, 78);
            this.butListPersons.TabIndex = 6;
            this.butListPersons.Text = "List of persons in the hospital";
            this.butListPersons.UseVisualStyleBackColor = false;
            this.butListPersons.Click += new System.EventHandler(this.butListPersons_Click);
            // 
            // butRemovePatient
            // 
            this.butRemovePatient.BackColor = System.Drawing.Color.Violet;
            this.butRemovePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRemovePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRemovePatient.ForeColor = System.Drawing.Color.White;
            this.butRemovePatient.Location = new System.Drawing.Point(34, 424);
            this.butRemovePatient.Margin = new System.Windows.Forms.Padding(2);
            this.butRemovePatient.Name = "butRemovePatient";
            this.butRemovePatient.Size = new System.Drawing.Size(104, 54);
            this.butRemovePatient.TabIndex = 5;
            this.butRemovePatient.Text = "Remove a patient";
            this.butRemovePatient.UseVisualStyleBackColor = false;
            this.butRemovePatient.Click += new System.EventHandler(this.butRemovePatient_Click);
            // 
            // butListPatients
            // 
            this.butListPatients.BackColor = System.Drawing.Color.Violet;
            this.butListPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butListPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListPatients.ForeColor = System.Drawing.Color.White;
            this.butListPatients.Location = new System.Drawing.Point(34, 331);
            this.butListPatients.Margin = new System.Windows.Forms.Padding(2);
            this.butListPatients.Name = "butListPatients";
            this.butListPatients.Size = new System.Drawing.Size(104, 78);
            this.butListPatients.TabIndex = 3;
            this.butListPatients.Text = "List of patients of one doctor";
            this.butListPatients.UseVisualStyleBackColor = false;
            this.butListPatients.Click += new System.EventHandler(this.butListPatients_Click);
            // 
            // butListDoctors
            // 
            this.butListDoctors.BackColor = System.Drawing.Color.Violet;
            this.butListDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butListDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListDoctors.ForeColor = System.Drawing.Color.White;
            this.butListDoctors.Location = new System.Drawing.Point(34, 246);
            this.butListDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.butListDoctors.Name = "butListDoctors";
            this.butListDoctors.Size = new System.Drawing.Size(104, 72);
            this.butListDoctors.TabIndex = 4;
            this.butListDoctors.Text = "List of doctors in the hospital";
            this.butListDoctors.UseVisualStyleBackColor = false;
            this.butListDoctors.Click += new System.EventHandler(this.butListDoctors_Click);
            // 
            // butRegisterStaff
            // 
            this.butRegisterStaff.BackColor = System.Drawing.Color.Violet;
            this.butRegisterStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegisterStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegisterStaff.ForeColor = System.Drawing.Color.White;
            this.butRegisterStaff.Location = new System.Drawing.Point(34, 177);
            this.butRegisterStaff.Margin = new System.Windows.Forms.Padding(2);
            this.butRegisterStaff.Name = "butRegisterStaff";
            this.butRegisterStaff.Size = new System.Drawing.Size(104, 54);
            this.butRegisterStaff.TabIndex = 3;
            this.butRegisterStaff.Text = "Register a staff";
            this.butRegisterStaff.UseVisualStyleBackColor = false;
            this.butRegisterStaff.Click += new System.EventHandler(this.butRegisterStaff_Click);
            // 
            // butRegisterPatient
            // 
            this.butRegisterPatient.BackColor = System.Drawing.Color.Violet;
            this.butRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegisterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegisterPatient.ForeColor = System.Drawing.Color.White;
            this.butRegisterPatient.Location = new System.Drawing.Point(34, 104);
            this.butRegisterPatient.Margin = new System.Windows.Forms.Padding(2);
            this.butRegisterPatient.Name = "butRegisterPatient";
            this.butRegisterPatient.Size = new System.Drawing.Size(104, 54);
            this.butRegisterPatient.TabIndex = 2;
            this.butRegisterPatient.Text = "Register a patient";
            this.butRegisterPatient.UseVisualStyleBackColor = false;
            this.butRegisterPatient.Click += new System.EventHandler(this.butRegisterPatient_Click);
            // 
            // butRegisterDoctor
            // 
            this.butRegisterDoctor.BackColor = System.Drawing.Color.Violet;
            this.butRegisterDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegisterDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegisterDoctor.ForeColor = System.Drawing.Color.White;
            this.butRegisterDoctor.Location = new System.Drawing.Point(34, 35);
            this.butRegisterDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.butRegisterDoctor.Name = "butRegisterDoctor";
            this.butRegisterDoctor.Size = new System.Drawing.Size(104, 54);
            this.butRegisterDoctor.TabIndex = 1;
            this.butRegisterDoctor.Text = "Register a doctor";
            this.butRegisterDoctor.UseVisualStyleBackColor = false;
            this.butRegisterDoctor.Click += new System.EventHandler(this.butRegisterDoctor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(600, 591);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hospitalEsplai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butListDoctors;
        private System.Windows.Forms.Button butRegisterStaff;
        private System.Windows.Forms.Button butRegisterPatient;
        private System.Windows.Forms.Button butRegisterDoctor;
        private System.Windows.Forms.Button butRemovePatient;
        private System.Windows.Forms.Button butListPatients;
        private System.Windows.Forms.Button butListPersons;
    }
}

