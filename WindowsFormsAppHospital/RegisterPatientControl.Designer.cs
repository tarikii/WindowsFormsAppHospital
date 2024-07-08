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
            this.doctorAssignedTextBox = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSubmitPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerPatient
            // 
            this.registerPatient.AutoSize = true;
            this.registerPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPatient.ForeColor = System.Drawing.Color.White;
            this.registerPatient.Location = new System.Drawing.Point(122, 28);
            this.registerPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerPatient.Name = "registerPatient";
            this.registerPatient.Size = new System.Drawing.Size(172, 24);
            this.registerPatient.TabIndex = 2;
            this.registerPatient.Text = "Register a patient";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(28, 115);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // namePatientTextBox
            // 
            this.namePatientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePatientTextBox.Location = new System.Drawing.Point(106, 118);
            this.namePatientTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namePatientTextBox.Name = "namePatientTextBox";
            this.namePatientTextBox.Size = new System.Drawing.Size(91, 23);
            this.namePatientTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(28, 225);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(48, 24);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age";
            // 
            // agePatientTextBox
            // 
            this.agePatientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agePatientTextBox.Location = new System.Drawing.Point(106, 228);
            this.agePatientTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agePatientTextBox.Name = "agePatientTextBox";
            this.agePatientTextBox.Size = new System.Drawing.Size(91, 23);
            this.agePatientTextBox.TabIndex = 6;
            // 
            // illnessLabel
            // 
            this.illnessLabel.AutoSize = true;
            this.illnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illnessLabel.ForeColor = System.Drawing.Color.White;
            this.illnessLabel.Location = new System.Drawing.Point(28, 320);
            this.illnessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.illnessLabel.Name = "illnessLabel";
            this.illnessLabel.Size = new System.Drawing.Size(64, 24);
            this.illnessLabel.TabIndex = 7;
            this.illnessLabel.Text = "Ilness";
            // 
            // illnessTextBox
            // 
            this.illnessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.illnessTextBox.Location = new System.Drawing.Point(106, 320);
            this.illnessTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.illnessTextBox.Name = "illnessTextBox";
            this.illnessTextBox.Size = new System.Drawing.Size(91, 23);
            this.illnessTextBox.TabIndex = 8;
            // 
            // doctorAssigned
            // 
            this.doctorAssigned.AutoSize = true;
            this.doctorAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorAssigned.ForeColor = System.Drawing.Color.White;
            this.doctorAssigned.Location = new System.Drawing.Point(28, 422);
            this.doctorAssigned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorAssigned.Name = "doctorAssigned";
            this.doctorAssigned.Size = new System.Drawing.Size(161, 24);
            this.doctorAssigned.TabIndex = 9;
            this.doctorAssigned.Text = "Doctor assigned";
            // 
            // doctorAssignedTextBox
            // 
            this.doctorAssignedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorAssignedTextBox.Location = new System.Drawing.Point(201, 424);
            this.doctorAssignedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorAssignedTextBox.Name = "doctorAssignedTextBox";
            this.doctorAssignedTextBox.Size = new System.Drawing.Size(91, 23);
            this.doctorAssignedTextBox.TabIndex = 10;
            // 
            // butCancel
            // 
            this.butCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.White;
            this.butCancel.Location = new System.Drawing.Point(18, 485);
            this.butCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(122, 89);
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
            this.butSubmitPatient.Location = new System.Drawing.Point(274, 485);
            this.butSubmitPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butSubmitPatient.Name = "butSubmitPatient";
            this.butSubmitPatient.Size = new System.Drawing.Size(122, 89);
            this.butSubmitPatient.TabIndex = 12;
            this.butSubmitPatient.Text = "Submit Patient";
            this.butSubmitPatient.UseVisualStyleBackColor = false;
            this.butSubmitPatient.Click += new System.EventHandler(this.butSubmitPatient_Click);
            // 
            // RegisterPatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.butSubmitPatient);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.doctorAssignedTextBox);
            this.Controls.Add(this.doctorAssigned);
            this.Controls.Add(this.illnessTextBox);
            this.Controls.Add(this.illnessLabel);
            this.Controls.Add(this.agePatientTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.namePatientTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.registerPatient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterPatientControl";
            this.Size = new System.Drawing.Size(416, 590);
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
        private System.Windows.Forms.TextBox doctorAssignedTextBox;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSubmitPatient;
    }
}
