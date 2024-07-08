namespace WindowsFormsAppHospital
{
    partial class RegisterPatientControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerPatient = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.namePatientTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.agePatientTextBox = new System.Windows.Forms.TextBox();
            this.illnessLabel = new System.Windows.Forms.Label();
            this.illnessTextBox = new System.Windows.Forms.TextBox();
            this.doctorAssigned = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmitPatient = new System.Windows.Forms.Button();
            this.listDoctorsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // registerPatient
            // 
            this.registerPatient.AutoSize = true;
            this.registerPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPatient.ForeColor = System.Drawing.Color.White;
            this.registerPatient.Location = new System.Drawing.Point(163, 34);
            this.registerPatient.Name = "registerPatient";
            this.registerPatient.Size = new System.Drawing.Size(219, 29);
            this.registerPatient.TabIndex = 2;
            this.registerPatient.Text = "Register a patient";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(37, 142);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 29);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // namePatientTextBox
            // 
            this.namePatientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePatientTextBox.Location = new System.Drawing.Point(141, 145);
            this.namePatientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namePatientTextBox.Name = "namePatientTextBox";
            this.namePatientTextBox.Size = new System.Drawing.Size(120, 26);
            this.namePatientTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(37, 277);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(59, 29);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            // 
            // agePatientTextBox
            // 
            this.agePatientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agePatientTextBox.Location = new System.Drawing.Point(141, 281);
            this.agePatientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agePatientTextBox.Name = "agePatientTextBox";
            this.agePatientTextBox.Size = new System.Drawing.Size(120, 26);
            this.agePatientTextBox.TabIndex = 6;
            // 
            // illnessLabel
            // 
            this.illnessLabel.AutoSize = true;
            this.illnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illnessLabel.ForeColor = System.Drawing.Color.White;
            this.illnessLabel.Location = new System.Drawing.Point(37, 394);
            this.illnessLabel.Name = "illnessLabel";
            this.illnessLabel.Size = new System.Drawing.Size(82, 29);
            this.illnessLabel.TabIndex = 7;
            this.illnessLabel.Text = "Ilness";
            // 
            // illnessTextBox
            // 
            this.illnessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illnessTextBox.Location = new System.Drawing.Point(141, 394);
            this.illnessTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.illnessTextBox.Name = "illnessTextBox";
            this.illnessTextBox.Size = new System.Drawing.Size(120, 26);
            this.illnessTextBox.TabIndex = 8;
            // 
            // doctorAssigned
            // 
            this.doctorAssigned.AutoSize = true;
            this.doctorAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorAssigned.ForeColor = System.Drawing.Color.White;
            this.doctorAssigned.Location = new System.Drawing.Point(37, 519);
            this.doctorAssigned.Name = "doctorAssigned";
            this.doctorAssigned.Size = new System.Drawing.Size(203, 29);
            this.doctorAssigned.TabIndex = 9;
            this.doctorAssigned.Text = "Doctor assigned";
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(24, 597);
            this.butCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(163, 110);
            this.butCancel.TabIndex = 11;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = false;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butSubmitPatient
            // 
            this.butSubmitPatient.BackColor = System.Drawing.Color.Violet;
            this.butSubmitPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSubmitPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSubmitPatient.ForeColor = System.Drawing.Color.White;
            this.butSubmitPatient.Location = new System.Drawing.Point(365, 597);
            this.butSubmitPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSubmitPatient.Name = "butSubmitPatient";
            this.butSubmitPatient.Size = new System.Drawing.Size(163, 110);
            this.butSubmitPatient.TabIndex = 12;
            this.butSubmitPatient.Text = "Submit Patient";
            this.butSubmitPatient.UseVisualStyleBackColor = false;
            this.butSubmitPatient.Click += new System.EventHandler(this.butSubmitPatient_Click);
            // 
            // listDoctorsComboBox
            // 
            this.listDoctorsComboBox.FormattingEnabled = true;
            this.listDoctorsComboBox.Location = new System.Drawing.Point(269, 525);
            this.listDoctorsComboBox.Name = "listDoctorsComboBox";
            this.listDoctorsComboBox.Size = new System.Drawing.Size(121, 24);
            this.listDoctorsComboBox.TabIndex = 13;
            // 
            // RegisterPatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.listDoctorsComboBox);
            this.Controls.Add(this.butSubmitPatient);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.doctorAssigned);
            this.Controls.Add(this.illnessTextBox);
            this.Controls.Add(this.illnessLabel);
            this.Controls.Add(this.agePatientTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.namePatientTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registerPatient);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterPatientControl";
            this.Size = new System.Drawing.Size(555, 726);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerPatient;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox namePatientTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox agePatientTextBox;
        private System.Windows.Forms.Label illnessLabel;
        private System.Windows.Forms.TextBox illnessTextBox;
        private System.Windows.Forms.Label doctorAssigned;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmitPatient;
        private System.Windows.Forms.ComboBox listDoctorsComboBox;
    }
}
